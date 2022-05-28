using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCatch : MonoBehaviour
{
    [SerializeField] Dog Main;
    [SerializeField] float Range;
    [SerializeField] LayerMask LayerMask;

    void Update()
    {
        if (Main.GetComponent<DogFallBackStatus>().CatchTarget)
        {
            return;
        }
        Collider[] Overlay = Physics.OverlapSphere(transform.position, Range, LayerMask);
        if (Overlay.Length > 0)
        {
            if (Overlay[0].GetComponent<HandJokeCollider>())
            {
                HandJoke CatchHandJoke = Overlay[0].GetComponent<HandJokeCollider>().getMain();
                Main.GetComponent<DogFallBackStatus>().CatchTarget = CatchHandJoke;
                Main.ToNewStatus(CharacterStatusEnum.Fallback);
            }

        }
    }
}
