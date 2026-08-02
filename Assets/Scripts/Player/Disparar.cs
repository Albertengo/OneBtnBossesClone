using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Disparar : ISkill
{
    [SerializeField] private ObjectPool pool;
    //public Transform Bullets;
    public Transform FirePoint;
    public GameObject BulletPrefab;
    bool canShoot = true;
    //private ObjectPool bulletPool;

    public Disparar(ObjectPool bulletPool)
    {
        this.pool = bulletPool;
    }

    //void FixedUpdate()
    //{
    //    //nuevo
    //    execute_skill(FirePoint);
    //}

    /*
    private IEnumerator Shoot(float seconds, Transform Firepoint)
    {
        //GameObject BulletPrefab = ObjectPool.SharedInstance.GetPooledObject();
        GameObject BulletPrefab = pool.GetPooledObject();
        if (BulletPrefab != null)
        {
            BulletPrefab.transform.position = FirePoint.transform.position;
            BulletPrefab.transform.rotation = FirePoint.transform.rotation;
            BulletPrefab.SetActive(true);
        }
        //Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation, Bullets);
        canShoot = false;
        yield return new WaitForSeconds(seconds);
        canShoot = true;

    }
    */

    public void execute_skill(Transform Firepoint)
    {
        GameObject bullet = pool.GetPooledObject();

        //if (bullet == null)
        //    return;

        if (bullet != null)
        {
            bullet.transform.position = Firepoint.position;
            bullet.transform.rotation = Firepoint.rotation;
            bullet.SetActive(true);
        }
        return;
    }

    //public void execute_skill(Transform Firepoint)//nuevo
    //{
    //    if (canShoot) //NO NUEVO
    //    {
    //        StartCoroutine(Shoot(0.1f));
    //    }
    //}
}
