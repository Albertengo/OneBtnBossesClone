using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint_Enemigo : movimientocircular
{
    [SerializeField] float tiempo_randomizer;
    bool change_direction;


    private void Start()
    {
        change_direction = true;
    }
    void Update()
    {
        MoveFirepoint();
        
    }

    void MoveFirepoint()
    {
        obj_rotation();
        if (change_direction)
        StartCoroutine(RandomizeDirection());
    }

    IEnumerator RandomizeDirection()
    {
        change_direction = false;

        yield return new WaitForSeconds(tiempo_randomizer);
        direccionHorario = (Random.value > 0.5);
        
        change_direction = true;
        yield break;
    }

}
