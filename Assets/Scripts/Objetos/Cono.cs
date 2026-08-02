using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cono : MonoBehaviour
{
    [SerializeField] private float tiempo = 2f;

    private void OnEnable()
    {
        StartCoroutine(Desactivar());
    }

    private IEnumerator Desactivar()
    {
        yield return new WaitForSeconds(tiempo);
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
