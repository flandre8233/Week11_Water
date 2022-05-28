using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandJokesControll : SingletonMonoBehavior<HandJokesControll>
{
    int _FieldCount = 12;
    public int FieldCount
    {
        get
        {
            return _FieldCount;
        }
        set
        {
            _FieldCount = value;
            if (_FieldCount <= 0)
            {
                StatusControll.ToNewStatus(new GameoverStatus());
            }
        }
    }
    public List<HandJoke> handJokes;

    public void ForceLeave()
    {
        foreach (var item in handJokes)
        {
            item.ToNewStatus(CharacterStatusEnum.Exit);
        }
    }
}
