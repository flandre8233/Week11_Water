using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCountdownText : CommonUIText
{
    public override void UpdateText()
    {
        text.text = TimeCountdown.instance.GetTime();
    }
}
