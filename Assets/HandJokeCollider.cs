using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandJokeCollider : MonoBehaviour
{
    [SerializeField] HandJoke Main;
    public HandJoke getMain()
    {
        return Main;
    }

    public void SetIsTouchable(bool IsTouchable)
    {
        gameObject.tag = (IsTouchable) ? "HandJoke" : "Untagged";
    }

    public void SetbeDetectable(bool IsDetectable)
    {
        gameObject.layer = IsDetectable ? 3 : 0;
    }
}
