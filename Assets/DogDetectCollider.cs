using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogDetectCollider : MonoBehaviour
{
    [SerializeField] Dog Main;
    public float Range;
    [SerializeField] LayerMask LayerMask;

    float RandomCd;

    void TryFind()
    {
        Transform Target = TryFindHandJokeTarget();
        Range += RandomCd;
        if (Target)
        {
            print("Finded");
            GetComponent<DogMoveToStatus>().Target = Target;
            Main.ToNewStatus(CharacterStatusEnum.MoveTo);
            Range = 0;
        }
    }

    Transform TryFindHandJokeTarget()
    {
        Collider[] Overlay = Physics.OverlapSphere(transform.position, Range, LayerMask);
        if (Overlay.Length > 0 && Overlay[0].GetComponent<HandJokeCollider>())
        {
            return Overlay[0].GetComponent<HandJokeCollider>().getMain().transform;
        }
        return null;
    }

    private void OnEnable()
    {
        RandomCd = Random.Range(2.0f, 3.0f);
        InvokeRepeating("TryFind", 0, RandomCd);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }
}