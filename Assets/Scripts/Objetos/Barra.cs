using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NOTA: script para el objeto de "Barra", tiene su comportamiento cuando se activa. Rota.

public class Barra : MonoBehaviour
{
    [Header("BEHAVIOUR")]
    [SerializeField] float speed = 50;
    [SerializeField] private float tiempo = 2f;

    private void OnEnable()
    {
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
}
