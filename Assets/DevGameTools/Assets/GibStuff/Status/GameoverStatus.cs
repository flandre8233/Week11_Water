using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameoverStatus : Status
{
    public override void Start()
    {
        HandJokesControll.instance.ForceLeave();
        BackPeople.instance.StartRun();

        int HandJokeLeft = HandJokesControll.instance.FieldCount;
        if (HandJokeLeft <= 0)
        {
            foreach (var item in DogsControll.instance.dogs)
            {
                item.ToNewStatus(CharacterStatusEnum.Exit);
            }
        }
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }

    public override void ExitStatus()
    {

    }
}