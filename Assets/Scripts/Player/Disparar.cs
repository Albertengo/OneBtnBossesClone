using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Disparar : MonoBehaviour
{
    public Transform Bullets;
    public Transform FirePoint;
    public GameObject BulletPrefab;
    bool canShoot = true;

    void FixedUpdate()
    {
        if (canShoot)
        {
            StartCoroutine(Shoot(0.1f));
        }
    }

    private IEnumerator Shoot(float seconds)
    {
        GameObject BulletPrefab = ObjectPool.SharedInstance.GetPooledObject();
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

}
