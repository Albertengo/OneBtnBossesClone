using System.Collections;
using UnityEngine;


public class Player_ATQ : MonoBehaviour
{
    [SerializeField] private Transform Firepoint;
    [SerializeField] private ObjectPool BulletsPool;
    private Disparar disparar;
    bool canShoot;

    private void Start()
    {
        disparar = new Disparar(BulletsPool);
        canShoot = true;
    }

    void FixedUpdate()
    {
        if (canShoot) 
            StartCoroutine(Shoot(0.1f));
    }
    private IEnumerator Shoot(float seconds)
    {
        ATK();
        canShoot = false;
        yield return new WaitForSeconds(seconds);
        canShoot = true;
    }
    void ATK()
    {
        disparar.execute_skill(Firepoint);
    }
}
