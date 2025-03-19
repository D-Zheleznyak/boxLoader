using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObject : MonoBehaviour
{
    private GameObject testObj;
    [SerializeField] private GameObject spawnPoint;

    [Header("--- Выбор коробки ---")]

    [SerializeField] private GameObject[] obj;
    private int[] chances = new int[] { 60, 30, 10 };

    [SerializeField] private int i;

    private void OnSelectObject()
    {
        i = Random.Range(0, 100);

        if (i < 10)
        {
            testObj = obj[2];
        }

        else if (i < 40)
        {
            testObj = obj[1];
        }

        else if (i < 100)
        {
            testObj = obj[0];
        }
    }
    public void OnSpawnObject()
    {
        OnSelectObject();

        Instantiate(testObj, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
}
