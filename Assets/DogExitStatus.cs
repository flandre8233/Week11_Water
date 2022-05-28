using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogExitStatus : MonoBehaviour
{
    private void OnEnable()
    {
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
