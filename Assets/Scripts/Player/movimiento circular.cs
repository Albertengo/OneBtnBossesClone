using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class movimientocircular : MonoBehaviour
{
    protected float rotation = 0;
    [SerializeField] protected float speed = 200;
    protected private bool direccionHorario = true;

    protected void SetSpeed()
    {
        rotation = rotation + speed * Time.deltaTime * (direccionHorario ? 1 : -1);

        //if (direccionHorario)
        //    SpeedChange();//Slow_Speed();
    }
    protected void obj_rotation()
    {
        SetSpeed();
        gameObject.transform.rotation = Quaternion.Euler(0, 0, rotation);
        gameObject.transform.Translate(0, 0 * Time.deltaTime, 0);
    }

  
    //protected void SpeedChange()
    //{
    //    speed = 150;
    //    Debug.Log("cambio de velocidad");
    //    for (int i = 0; i < 5; i++)
    //    {
    //        speed += i; // Aumenta la variable "total" sumándole "i"
    //    }
    //    //if (speed < 200)
    //    //{
    //    //    speed++;
    //    //}
    //    //se puede poner una variable aparte de velocidad que tenga como referencia la original
    //    //que contaria como el max de velocidad?? idk, pero poner esta funcion con corrutina?

    //}
    //o hacer directamente una funcion de corrutina que sea que le baja la velocidad por unos segundos
    //con otra variable de velocidad para que desp vuelva a la original?
}
