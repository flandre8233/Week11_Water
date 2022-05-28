using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    [SerializeField]
    CharacterStatusEnum Status;
    Dictionary<CharacterStatusEnum, MonoBehaviour> StatusDict;
    public Vector3 OrlPos;

    private void Start()
    {
        if (OrlPos == new Vector3())
        {
            OrlPos = transform.position;
        }
        StatusDict = new Dictionary<CharacterStatusEnum, MonoBehaviour>();
        StatusDict.Add(CharacterStatusEnum.Idle, GetComponent<DogIdleStatus>());
        StatusDict.Add(CharacterStatusEnum.MoveTo, GetComponent<DogMoveToStatus>());
        StatusDict.Add(CharacterStatusEnum.Fallback, GetComponent<DogFallBackStatus>());
        StatusDict.Add(CharacterStatusEnum.Exit, GetComponent<DogExitStatus>());
        ToNewStatus(CharacterStatusEnum.Idle);
    }

    public void ToNewStatus(CharacterStatusEnum NewStatus)
    {
        StatusDict[Status].enabled = false;
        Status = NewStatus;
        StatusDict[NewStatus].enabled = true;
    }

}
