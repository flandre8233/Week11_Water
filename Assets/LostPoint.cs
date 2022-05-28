using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostPoint : SingletonMonoBehavior<LostPoint>
{
    public void OnLost()
    {
        RectTransform rectT = ResourcesSpawner.Spawn("Lost", 5f).GetComponent<RectTransform>();
        rectT.SetParent(transform);
        rectT.anchoredPosition = new Vector2(0, 0);
        rectT.localScale = new Vector3(1, 1, 1);
    }
}
