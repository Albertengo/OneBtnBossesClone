using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Cono_Ataque : ISkill//Skill_Enemigo//Ataques_Enemigo, ISkill_Enemigo
{
    float[] angles = { -20, -10, 0, 10, 20 };
    private ObjectPool pool;

    public Cono_Ataque(ObjectPool pool)
    {
        this.pool = pool;
    }


    public void execute_skill(UnityEngine.Transform Firepoint)
    {
        int index = Random.Range(0, angles.Length);
        float angle = angles[index];
        GameObject cono = pool.GetPooledObject();
    
        if (cono != null)
        {
            cono.transform.position = Firepoint.position;
            cono.transform.rotation =
            Firepoint.rotation * Quaternion.Euler(0, 0, angle);

            cono.SetActive(true);
        }

        //Random.Range(0, 4);
        //foreach (float angle in angles)
        //{
        //    GameObject cono = pool.GetPooledObject();

        //    if (cono != null)
        //    {
        //        cono.transform.position = Firepoint.position;
        //        cono.transform.rotation =
        //        Firepoint.rotation * Quaternion.Euler(0, 0, angle);

        //        cono.SetActive(true);
        //    }
        //}
    }


    //public GameObject prefab;

    //public override void execute_skill()
    //{
    //    skill();
    //}
    /*
    void skill()
    {
        new Instantiate(prefab, transform.position, transform.rotation);
        Debug.Log("Skill lanzada");
    }
    */
    // Start is called before the first frame update

    //public void skill()
    //{
    //    Instantiate(prefab, transform.position, transform.rotation);
    //    Debug.Log("Skill lanzada");
    //}
}
