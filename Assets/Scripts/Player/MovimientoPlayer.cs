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
        StartCoroutine(Slow_Speed());
    }
    IEnumerator Slow_Speed()
    {
        speed = 100;

        while (speed < 200)
        {
            speed = speed + 5;
            yield return new WaitForSeconds(0.1f);
        }
    }

}
