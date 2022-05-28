using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogIdleStatus : MonoBehaviour
{
    private void OnEnable()
    {
        gameObject.AddComponent<FaceAtBack>();
        gameObject.GetComponent<DogDetectCollider>().enabled = true;
    }

    void Update()
    {

    }

    private void OnDisable()
    {
        Destroy(GetComponent<FaceAtBack>());
        gameObject.GetComponent<DogDetectCollider>().enabled = false;

    }
}
