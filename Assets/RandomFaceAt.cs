using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFaceAt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Vector3 lookPos = Random.insideUnitSphere;
        lookPos.y = 0;
        transform.rotation = Quaternion.LookRotation(lookPos);
        Destroy(this);
    }


}
