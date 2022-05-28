using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleStatus : MonoBehaviour
{
    [SerializeField]
    HandJokeCollider JokeCollider;
    private void OnEnable()
    {
        JokeCollider.SetIsTouchable(true);
        gameObject.AddComponent<FaceAtFront>();
    }
    void Update()
    {

    }
    private void OnDisable()
    {
        Destroy(GetComponent<FaceAtFront>());
    }
}
