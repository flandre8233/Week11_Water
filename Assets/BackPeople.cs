using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPeople : SingletonMonoBehavior<BackPeople>
{
    [SerializeField] List<GameObject> AndRifeis;

    public void StartRun()
    {
        foreach (var item in AndRifeis)
        {
            Vector3 TargetPos = new Vector3(item.transform.position.x, item.transform.position.y, -40);
            HandMoveTo.Create(item, TargetPos, 6f);
            Destroy(item, 2f);
        }
    }
}
