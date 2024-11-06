using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    float rotation = 0;
    public float speed;
    private bool direccionHorario = true;

    void Update()
    {
        circularmovement();
        if (Input.GetKeyUp(KeyCode.E))
        {
            change_direction();
        }
    }

    void circularmovement()
    {
        rotation = rotation + 200 * Time.deltaTime * (direccionHorario ? 1 : -1); ;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, rotation);
        gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
    }
    void change_direction()
    {
        direccionHorario = !direccionHorario;
    }

}
