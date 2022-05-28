using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyChanger : SingletonMonoBehavior<dummyChanger>
{
    [SerializeField] GameObject dummy;
    [SerializeField] GameObject Real;

    public void SetGameStart(){
        dummy.SetActive(false);
        Real.SetActive(true);
    }
}
