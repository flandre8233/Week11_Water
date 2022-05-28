using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToStatus : MonoBehaviour
{
    public Vector3 TargetPosition;
    [SerializeField]
    HandJokeCollider JokeCollider;
    HandMoveTo HandMoveTo;
    private void OnEnable()
    {
        HandMoveTo = HandMoveTo.Create(gameObject, TargetPosition,5f);
        JokeCollider.SetIsTouchable(false);
    }
    void Update()
    {
        if (MovePartsEndListener())
        {
            GetComponent<HandJoke>().ToNewStatus(CharacterStatusEnum.Idle);
        }

    }
    private void OnDisable()
    {
        Destroy(HandMoveTo);
    }

    bool MovePartsEndListener()
    {
        return HandMoveTo == null;
    }
}
