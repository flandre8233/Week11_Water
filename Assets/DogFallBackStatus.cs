using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFallBackStatus : MonoBehaviour
{
    public HandJoke CatchTarget;
    HandMoveTo fallback;


    private void OnEnable()
    {
        CatchTarget.transform.parent = transform;
        CatchTarget.ToNewStatus(CharacterStatusEnum.Busted);

        Vector3 FallBackPos = transform.position - (Vector3.back * 80);
        fallback = HandMoveTo.Create(gameObject, FallBackPos, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= 20)
        {
            Destroy(fallback);
            GetComponent<DogMoveToStatus>().TargetPosition = GetComponent<Dog>().OrlPos;
            GetComponent<Dog>().ToNewStatus(CharacterStatusEnum.MoveTo);
            Destroy(CatchTarget.gameObject);
        }
    }

    private void OnDisable()
    {
        Destroy(fallback);
    }
}
