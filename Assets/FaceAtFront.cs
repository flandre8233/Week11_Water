using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceAtFront : MonoBehaviour
{
    void Update()
    {
        Vector3 lookPos = new Vector3(0, 0, 1);
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 5);
    }
}
