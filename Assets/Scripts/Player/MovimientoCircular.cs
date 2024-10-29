using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCircular : MonoBehaviour
{
    public float radio = 5f;          // Radio del movimiento circular
    public float velocidadAngular = 2f; // Velocidad de rotación en radianes por segundo
    private bool direccionHorario = true; // Dirección del movimiento (horario o antihorario)

    private float angulo = 0f;          // Ángulo en radianes
    [SerializeField] private Vector3 centro;             // Centro del círculo

    void Start()
    {
        // Guardamos la posición inicial del jugador como el centro de la órbita
        centro = transform.position;
    }

    void Update()
    {
        // Cambiar dirección al presionar una tecla (por ejemplo, la tecla "Espacio")
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direccionHorario = !direccionHorario; // Cambia la dirección del movimiento
        }

        // Calcular el incremento de ángulo en función de la velocidad y dirección
        float incremento = velocidadAngular * Time.deltaTime * (direccionHorario ? 1 : -1);
        angulo += incremento;

        // Calcular nueva posición usando seno y coseno para movimiento circular
        float x = centro.x + radio * Mathf.Cos(angulo);
        float z = centro.z + radio * Mathf.Sin(angulo);

        // Actualizar la posición del jugador manteniendo Y constante
        transform.position = new Vector3(x, transform.position.y, z);
    }
}
