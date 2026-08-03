using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Disparar : ISkill
{
    [SerializeField] private ObjectPool pool;
    public Transform FirePoint;

    public Disparar(ObjectPool bulletPool)
    {
        this.pool = bulletPool;
    }

    public void execute_skill(Transform Firepoint)
    {
        GameObject bullet = pool.GetPooledObject();

        if (bullet != null)
        {
            bullet.transform.position = Firepoint.position;
            bullet.transform.rotation = Firepoint.rotation;
            bullet.SetActive(true);
        }
        return;
    }

}
