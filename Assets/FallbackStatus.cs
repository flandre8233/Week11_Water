using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallbackStatus : MonoBehaviour
{
    HandMoveTo fallback;
    Vector3 OrlPos;
    private void OnEnable()
    {
        Vector3 FallBackPos = transform.position + (Vector3.back * 20);
        fallback = HandMoveTo.Create(gameObject, FallBackPos, 8f);
        OrlPos = transform.position;
        HandJokesControll.instance.FieldCount--;
    }

    // Update is called once per frame
    void Update()
    {
        if (!fallback)
        {
            GetComponent<MoveToStatus>().TargetPosition = OrlPos;
            GetComponent<HandJoke>().ToNewStatus(CharacterStatusEnum.MoveTo);
        }
    }

    private void OnDisable()
    {
        Destroy(fallback);
        HandJokesControll.instance.FieldCount++;
    }

}
