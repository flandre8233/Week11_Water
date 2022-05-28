using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teargass : SingletonMonoBehavior<Teargass>
{
    [SerializeField] List<GameObject> TeargasList;

    [SerializeField] GameObject Spy;
    public void Init()
    {
        Invoke("RandomTeargasOut", 20);
        Invoke("RandomTeargasOut", 60);
        Invoke("RandomTeargasOut", 80);
        Invoke("SpyOut", 90);
    }

    void SpyOut()
    {
        Spy.SetActive(true);
    }
    void RandomTeargasOut()
    {
        GameObject Teargas = TeargasList[Random.Range(0, TeargasList.Count)];
        Teargas.SetActive(true);
        TeargasList.Remove(Teargas);
    }
}
