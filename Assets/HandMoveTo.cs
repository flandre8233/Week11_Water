using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMoveTo : MonoBehaviour
{
    [SerializeField] Transform TargetTrans;
    [SerializeField] Vector3 TargetPosition;
    [SerializeField] float MoveSpeed;
    [SerializeField] float damping;
    public static HandMoveTo Create(GameObject TargetObject, Vector3 _TargetPostition,float _MoveSpeed)
    {
        HandMoveTo MoveTo = TargetObject.AddComponent<HandMoveTo>();
        MoveTo.TargetPosition = _TargetPostition;
        MoveTo.MoveSpeed = _MoveSpeed;
        MoveTo.damping = 15f;
        return MoveTo;
    }

    public static HandMoveTo Create(GameObject TargetObject, Transform _TargetTrans,float _MoveSpeed)
    {
        HandMoveTo MoveTo = TargetObject.AddComponent<HandMoveTo>();
        MoveTo.TargetTrans = _TargetTrans;
        MoveTo.MoveSpeed = _MoveSpeed;
        MoveTo.damping = 15f;
        return MoveTo;
    }

    void Update()
    {
        if (TargetTrans)
        {
            TargetPosition = TargetTrans.position;
        }
        Move();
        Rotate();
        if (IsFinishListener())
        {
            OnFinish();
        }
    }

    void Move()
    {
        transform.position += transform.forward * Time.deltaTime * MoveSpeed;
    }

    void Rotate()
    {
        Vector3 lookPos = TargetPosition - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
    }

    bool IsFinishListener()
    {
        Vector3 lookPos = TargetPosition - transform.position;
        lookPos.y = 0;
        return (lookPos.magnitude <= 0.3f);
    }
    public void OnFinish()
    {
        Destroy(this);
    }
}
