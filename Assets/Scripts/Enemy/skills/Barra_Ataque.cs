using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Barra_Ataque : ISkill
{
    private ObjectPool pool;
    

    public Barra_Ataque(ObjectPool pool)
    {
        this.pool = pool;
    }

    public void execute_skill(UnityEngine.Transform Firepoint)
    {
        GameObject barra = pool.GetPooledObject();
        if (barra != null)
        {
            barra.transform.position = Firepoint.position;
            barra.transform.rotation = Firepoint.rotation;
            //barra.transform.Rotate(Vector3.up * speed * Time.deltaTime);

            barra.SetActive(true);
        }
        //Spin();
    }

    //void Spin()
    //{
        
    //    barra.transform.Rotate(Vector3.up * speed * Time.deltaTime);
    //}
    
}
