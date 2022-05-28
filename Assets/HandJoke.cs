using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterStatusEnum
{
    Idle,
    MoveTo,
    Fallback,
    Busted,
    Exit
}

public class HandJoke : MonoBehaviour
{
    [SerializeField]
    CharacterStatusEnum Status;
    Dictionary<CharacterStatusEnum, MonoBehaviour> StatusDict;

    private void Start()
    {
        StatusDict = new Dictionary<CharacterStatusEnum, MonoBehaviour>();
        StatusDict.Add(CharacterStatusEnum.Idle, GetComponent<IdleStatus>());
        StatusDict.Add(CharacterStatusEnum.MoveTo, GetComponent<MoveToStatus>());
        StatusDict.Add(CharacterStatusEnum.Fallback, GetComponent<FallbackStatus>());
        StatusDict.Add(CharacterStatusEnum.Busted, GetComponent<BustedStatus>());
        StatusDict.Add(CharacterStatusEnum.Exit, GetComponent<ExitStatus>());

        ToNewStatus(CharacterStatusEnum.Idle);
    }

    public void ToNewStatus(CharacterStatusEnum NewStatus)
    {
        StatusDict[Status].enabled = false;
        Status = NewStatus;
        StatusDict[NewStatus].enabled = true;
    }

    public void OnSelectEnter()
    {
        GetComponent<Outline>().enabled = true;
    }
    public void OnSelectExit()
    {
        if (GetComponent<Outline>())
        {
            GetComponent<Outline>().enabled = false;
        }
    }

}
