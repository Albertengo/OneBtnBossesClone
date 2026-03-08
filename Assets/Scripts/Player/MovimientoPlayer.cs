using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    float rotation = 0;
    [SerializeField] float speed = 200;
    //public float speed;
    private bool direccionHorario = true;

    void Update()
    {
        circular_movement();
        if (Input.GetKeyUp(KeyCode.E))
        {
            change_direction();
        }
    }

    void circular_movement()
    {
        /*
        switch (direccionHorario)
        {
            case true:
                //rotation -= speed + Time.deltaTime;
                //gameObject.transform.Translate(0, angle -= speed + Time.deltaTime, 0);
                break;

            case false:
                //rotation -= speed * Time.deltaTime; //cambia velocidad
                break;
        }
        */

        Player_rotation();
    }
    void change_direction()
    {
        direccionHorario = !direccionHorario;
    }

    void Player_rotation()
    {
        rotation = rotation + speed * Time.deltaTime * (direccionHorario ? 1 : -1);
        gameObject.transform.rotation = Quaternion.Euler(0, 0, rotation);
        gameObject.transform.Translate(0, 0 * Time.deltaTime, 0);
    }

}
