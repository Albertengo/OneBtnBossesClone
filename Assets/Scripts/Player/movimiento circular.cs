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
    }
    protected void obj_rotation()
    {
        SetSpeed();
        gameObject.transform.rotation = Quaternion.Euler(0, 0, rotation);
        gameObject.transform.Translate(0, 0 * Time.deltaTime, 0);
    }

}
