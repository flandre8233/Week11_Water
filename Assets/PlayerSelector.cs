using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelector : SingletonMonoBehavior<PlayerSelector>
{
    [SerializeField] HandJoke CurrentSelected;
    public void OnSelectedHandJoke(HandJoke NewClickHandJoke)
    {
        CurrentSelected = NewClickHandJoke;
        CurrentSelected.OnSelectEnter();
    }

    void OnSelectExit()
    {
        CurrentSelected.OnSelectExit();
    }

    public void ClearSelected()
    {
        OnSelectExit();
        CurrentSelected = null;
    }

    public bool IsSelected()
    {
        return GetCurrent() != null;
    }

    public HandJoke GetCurrent()
    {
        return CurrentSelected;
    }
}
