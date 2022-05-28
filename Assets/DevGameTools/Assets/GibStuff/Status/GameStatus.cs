using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameStatus : Status
{
    public override void Start()
    {
        dummyChanger.instance.SetGameStart();
        Teargass.instance.Init();
    }

    public override void Update()
    {

    }

    public override void ExitStatus()
    {
    }
}