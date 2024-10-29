using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCircular : MonoBehaviour
{
    public float radio = 5f;          // Radio del movimiento circular
    public float velocidadAngular = 2f; // Velocidad de rotaci�n en radianes por segundo
    private bool direccionHorario = true; // Direcci�n del movimiento (horario o antihorario)

    private float angulo = 0f;          // �ngulo en radianes
    [SerializeField] private Vector3 centro;             // Centro del c�rculo

    void Start()
    {
        // Guardamos la posici�n inicial del jugador como el centro de la �rbita
        centro = transform.position;
    }

    void Update()
    {
        // Cambiar direcci�n al presionar una tecla (por ejemplo, la tecla "Espacio")
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direccionHorario = !direccionHorario; // Cambia la direcci�n del movimiento
        }

        // Calcular el incremento de �ngulo en funci�n de la velocidad y direcci�n
        float incremento = velocidadAngular * Time.deltaTime * (direccionHorario ? 1 : -1);
        angulo += incremento;

        // Calcular nueva posici�n usando seno y coseno para movimiento circular
        float x = centro.x + radio * Mathf.Cos(angulo);
        float z = centro.z + radio * Mathf.Sin(angulo);

        // Actualizar la posici�n del jugador manteniendo Y constante
        transform.position = new Vector3(x, transform.position.y, z);
    }
}
