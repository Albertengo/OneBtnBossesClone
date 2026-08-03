using System.Collections;
using UnityEngine;

//NOTA: script para el objeto de "Cono", tiene su comportamiento cuando se activa.
public class Cono : MonoBehaviour
{
    [Header("BEHAVIOUR")]
    [SerializeField] private float tiempo = 2f;

    private void OnEnable()
    {
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
}
