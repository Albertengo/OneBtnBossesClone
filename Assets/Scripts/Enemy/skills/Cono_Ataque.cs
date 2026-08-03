using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Cono_Ataque : ISkill
{
    float[] angles = { -20, -10, 0, 10, 20 };
    private ObjectPool pool;
    float angle;

    public Cono_Ataque(ObjectPool pool)
    {
        this.pool = pool;
    }


    public void execute_skill(UnityEngine.Transform Firepoint)
    {
        Randomize_Angle();

        GameObject cono = pool.GetPooledObject();
    
        if (cono != null)
        {
            cono.transform.position = Firepoint.position;
            cono.transform.rotation = Firepoint.rotation * Quaternion.Euler(0, 0, angle);

            cono.SetActive(true);
        }
    }

    public void Randomize_Angle()
    {
        int index = Random.Range(0, angles.Length);
        angle = angles[index];
    }
}
