using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitStatus : MonoBehaviour
{
    [SerializeField] HandJokeCollider JokeCollider;
    private void OnEnable()
    {
        JokeCollider.SetIsTouchable(false);
        JokeCollider.SetbeDetectable(false);
        Vector3 TargetPos = new Vector3(transform.position.x, transform.position.y, -40);
        HandMoveTo.Create(gameObject, TargetPos, 6f);
    }
    void Update()
    {
        if (transform.position.z <= -30)
        {
            Destroy(gameObject);
        }
    }

    private void OnDisable()
    {
    }
}
