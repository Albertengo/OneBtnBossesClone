using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;
    //int randomIndex;
    public int poolsize;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;

    //private void AddRandomObstaclesToPool()
    //{
    //    for (int i = 0; i < amountToPool; i++)
    //    {
    //        randomIndex = Random.Range(0, ObstaclePrefabList.Length);
    //        //randomObstacle = obstaclePrefabList[randomIndex];
    //    }
    //}
    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        AddToPool(poolsize);
    }

    void AddToPool(int amount)
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amount; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
            tmp.transform.parent = transform;
        }
    }
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < poolsize; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)//activeSelf)
            {
                //pooledObjects[i].SetActive(true);
                return pooledObjects[i];
            }
        }
        return null;
    }
}
