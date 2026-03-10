using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : movimientocircular
{
    //private bool direccionHorario = true;

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
        //SetSpeed();
        //rotation = rotation * (direccionHorario ? 1 : -1);
        obj_rotation();
    }
    void change_direction()
    {
        direccionHorario = !direccionHorario;
    }

    //void Player_rotation()
    //{
    //    rotation = rotation + speed * Time.deltaTime * (direccionHorario ? 1 : -1);
    //    gameObject.transform.rotation = Quaternion.Euler(0, 0, rotation);
    //    gameObject.transform.Translate(0, 0 * Time.deltaTime, 0);
    //}

}
