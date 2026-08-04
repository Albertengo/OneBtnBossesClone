using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ObjectPool : MonoBehaviour
{
    public int poolsize;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;

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
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
