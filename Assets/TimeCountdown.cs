using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TimeCountdown : SingletonMonoBehavior<TimeCountdown>
{
    [SerializeField] TimeCountdownText textView;
    public float CurrentTime;
    private void Start()
    {
        CurrentTime = 120;
    }
    void Update()
    {
        CurrentTime -= Time.deltaTime;
        if (CurrentTime <= 0)
        {
            CurrentTime = 0;
            StatusControll.ToNewStatus(new GameoverStatus());
        }
        textView.UpdateText();
    }

    public string GetTime()
    {
        TimeSpan time = TimeSpan.FromSeconds(CurrentTime);
        return time.ToString("mm':'ss");
    }
}
