using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogsControll : SingletonMonoBehavior<DogsControll>
{
    [SerializeField]
    public List<Dog> dogs;
}
