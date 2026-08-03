using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NOTA: este script es padre para todos los objetos con vida, definiendo cómo reciben daño (player y enemigo)

public abstract class Vida : MonoBehaviour
{
    [SerializeField] private float SaludMax;
    [SerializeField] float SaludActual;

    [SerializeField] int DañoRecibido;

    [SerializeField] HealthSlider HealthBar;

    void Start()
    {
        SaludActual = SaludMax;
        HealthBar.startHealthBar(SaludActual);
    }

    #region Code

    public void recibirDaño(int daño)
    {
        SaludActual = SaludActual - daño;
        HealthBar.SetHealth(SaludActual);
        if (SaludActual <= 0)
        {
            Death();
            HealthBar.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //para cuando es atacado por el jugador o el enemigo
    {
        if (collision.gameObject.CompareTag("Bullet") || collision.CompareTag("Cone"))
        {
            recibirDaño(DañoRecibido);
        }
    }

    protected abstract void Death();
    #endregion
}
