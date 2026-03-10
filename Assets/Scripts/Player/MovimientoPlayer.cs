using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : movimientocircular
{
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
        obj_rotation();
    }
    void change_direction()
    {
        direccionHorario = !direccionHorario;
    }

}
