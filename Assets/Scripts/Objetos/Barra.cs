using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    [SerializeField] float speed = 50;
    //float rotation = 0;
    [SerializeField] private float tiempo = 2f;
    // Start is called before the first frame update
    private void OnEnable()
    {
        //Spin();
        StartCoroutine(Spin());
        StartCoroutine(DisableAfterTime());
    }

    IEnumerator DisableAfterTime()
    {
        yield return new WaitForSeconds(tiempo);

        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    IEnumerator Spin()
    {
        while (true)
        {
            transform.Rotate(0, 0, speed * Time.deltaTime);
            yield return null;
        }
    }
    //void Spin()
    //{
    //    //SetSpeed();
    //    //gameObject.transform.rotation = Quaternion.Euler(0, 0, rotation);
    //    //gameObject.transform.Translate(0, 0 * Time.deltaTime, 0);
    //    transform.Rotate(0, 0, speed * Time.deltaTime);
    //    //transform.Rotate(Vector2.up * speed * Time.deltaTime);
    //}
    //protected void SetSpeed()
    //{
    //    rotation = rotation + speed * Time.deltaTime;
    //}
}
