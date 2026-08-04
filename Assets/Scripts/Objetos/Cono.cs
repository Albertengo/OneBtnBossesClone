using System.Collections;
using UnityEngine;

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
