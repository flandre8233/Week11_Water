using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BustedStatus : MonoBehaviour
{
    [SerializeField]
    HandJokeCollider JokeCollider;
    [SerializeField] Transform ViewTrans;
    [SerializeField] GameObject BackToIndia;
    private void OnEnable()
    {
        HandJokesControll.instance.FieldCount--;
        HandJokesControll.instance.handJokes.Remove(GetComponent<HandJoke>());
        JokeCollider.SetIsTouchable(false);
        JokeCollider.SetbeDetectable(false);
        BackToIndia.SetActive(true);
        Destroy(JokeCollider);
        Destroy(GetComponent<Outline>());
        Destroy(GetComponent<IdleStatus>());
        Destroy(GetComponent<MoveToStatus>());
        Destroy(GetComponent<FallbackStatus>());
        ViewTrans.localPosition = new Vector3(0, -0.5f, 0);
        ViewTrans.localEulerAngles = new Vector3(90, 180, 0);
        LostPoint.instance.OnLost();
        if (PlayerSelector.instance.GetCurrent() == GetComponent<HandJoke>())
        {
            PlayerSelector.instance.ClearSelected();
        }
    }
    void Update()
    {

    }
    private void OnDisable()
    {

    }


}
