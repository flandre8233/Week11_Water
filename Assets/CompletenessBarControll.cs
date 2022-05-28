using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletenessBarControll : SingletonMonoBehavior<CompletenessBarControll>
{
    [SerializeField] Healthbar bar;
    float WantedVal;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int handJokesCount = HandJokesControll.instance.handJokes.Count;
        float Rate = 1;
        if (handJokesCount < 12)
        {
            Rate = ((float)handJokesCount / 12) * 0.5f;
        }
        WantedVal = Mathf.Lerp(WantedVal, Rate, Time.deltaTime * 5);
        bar.SetHealth(WantedVal * 100);
    }
}
