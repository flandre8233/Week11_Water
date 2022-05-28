using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMoveToStatus : MonoBehaviour
{
    public Transform Target;
    public Vector3 TargetPosition;

    HandMoveTo HandMoveTo;

    private void OnEnable()
    {
        if (Target)
        {
            HandMoveTo = HandMoveTo.Create(gameObject, Target, 6f);
            Invoke("Return", 3f);
        }
        else
        {
            HandMoveTo = HandMoveTo.Create(gameObject, TargetPosition, 4f);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (!HandMoveTo)
        {
            GetComponent<Dog>().ToNewStatus(CharacterStatusEnum.Idle);
        }

    }

    void Return()
    {
        TargetPosition = GetComponent<Dog>().OrlPos;
        GetComponent<Dog>().ToNewStatus(CharacterStatusEnum.MoveTo);
    }

    private void OnDisable()
    {
        Target = null;
        Destroy(HandMoveTo);
        CancelInvoke();
    }
}
