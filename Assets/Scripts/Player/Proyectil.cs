using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public Transform Bullets;
    public Transform FirePoint;
    public GameObject BulletPrefab;
    bool canShoot = true;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (canShoot)
        {
            StartCoroutine(Shoot(0.1f));
        }
    }

    private IEnumerator Shoot(float seconds)
    {
        Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation, Bullets);
        canShoot = false;
        yield return new WaitForSeconds(seconds);
        canShoot = true;

    }

}
