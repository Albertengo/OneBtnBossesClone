using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet") || collision.CompareTag("Cone"))
        {
            recibirDaño(DañoRecibido);
        }
    }

    protected abstract void Death();
    #endregion
}
