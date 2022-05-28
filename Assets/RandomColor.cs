using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    void Start()
    {
        float RandX = Random.Range(0.0f,1.0f);
        float RandY = Random.Range(0.0f,1.0f);
        float RandZ = Random.Range(0.0f,1.0f);
        GetComponent<MeshRenderer>().material.color = new Color(RandX,RandY,RandZ,1);
    }
}
