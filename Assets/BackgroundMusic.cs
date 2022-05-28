using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : SingletonMonoBehavior<BackgroundMusic>
{
    [SerializeField]
    AudioSource source;
    public void SetPlay()
    {
        source.enabled = true;
    }
}
