using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vida : MonoBehaviour
{
    [SerializeField] private float SaludMax;
    [SerializeField] float SaludActual;

    [SerializeField] int DañoRecibido;

    void Start()
    {
        SaludActual = SaludMax;
    }

    #region Code

    public void recibirDaño(int daño)
    {
        SaludActual = SaludActual - daño;
        if (SaludActual <= 0)
        {
            Death();
            //Destroy(gameObject);
            //Debug.Log("Enemigo eliminado");
            //nivel terminado
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //para cuando es atacado por el jugador o el enemigo
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            recibirDaño(DañoRecibido);
        }
    }

    protected abstract void Death();
    #endregion
}
