using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogChase : MonoBehaviour
{
    [SerializeField] HandJoke Target;
    [SerializeField] float MoveSpeed;
    [SerializeField] float damping;
    public static DogChase Create(GameObject TargetObject, HandJoke _Target)
    {
        DogChase MoveTo = TargetObject.AddComponent<DogChase>();
        MoveTo.Target = _Target;
        MoveTo.MoveSpeed = 5f;
        MoveTo.damping = 15f;
        return MoveTo;
    }

    void Update()
    {
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
        Vector3 lookPos = Target.transform.position - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
    }

    bool IsFinishListener()
    {
        Vector3 lookPos = Target.transform.position - transform.position;
        lookPos.y = 0;
        return (lookPos.magnitude <= 0.1f);
    }
    public void OnFinish()
    {
        Destroy(this);
    }
}
