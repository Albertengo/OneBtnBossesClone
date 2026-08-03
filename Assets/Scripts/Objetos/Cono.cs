using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cono : MonoBehaviour
{
    //NOTA: cambiar nombre de este script a "Desactivar_Skill" o algo asi, ponerlo en todas las skills

    [SerializeField] private float tiempo = 2f;
    //[SerializeField] private int daño = 10;

    private void OnEnable()
    {
        StartCoroutine(DisableAfterTime());
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        Vida vida = collision.GetComponent<Vida>();

    //        if (vida != null)
    //            vida.recibirDaño(daño);
    //    }
    //}

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
