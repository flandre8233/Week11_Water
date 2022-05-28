using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDayNight : MonoBehaviour
{
    void Update()
    {
        float Progress = 0;
        if (TimeCountdown.instance)
        {
            Progress = 1 - (TimeCountdown.instance.CurrentTime / 120);
        }
        float WantedAngles = Mathf.Lerp(35, 230, Progress);
        transform.localEulerAngles = new Vector3(WantedAngles, -115.3f, 0f);
    }
}
