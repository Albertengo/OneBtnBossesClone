using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    [SerializeField] private float SaludMax;
    [SerializeField] float salud_Enemy;
    [SerializeField] int da�oPlayer;
    void Start()
    {
        salud_Enemy = SaludMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void recibirDa�o(int da�o)
    {
        salud_Enemy = salud_Enemy - da�o;
        if (salud_Enemy <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemigo eliminado");
            //nivel terminado
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //para cuando es atacado por el jugador
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            recibirDa�o(da�oPlayer);
        }
    }
}
