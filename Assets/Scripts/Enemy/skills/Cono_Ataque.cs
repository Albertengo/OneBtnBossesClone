using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Cono_Ataque : MonoBehaviour//Skill_Enemigo//Ataques_Enemigo, ISkill_Enemigo
{
    public GameObject prefab;

    //public override void execute_skill()
    //{
    //    skill();
    //}

    void skill()
    {
        new Instantiate(prefab, transform.position, transform.rotation);
        Debug.Log("Skill lanzada");
    }
    private void SSSkill()
    {
        Instantiate(prefab, transform.position, transform.rotation);
        Debug.Log("Skill lanzada");
    }

    // Start is called before the first frame update
    /*
   new void Start()
   {

   }

   // Update is called once per frame
   protected void Update()
   {

   }

   */

    //public void skill()
    //{
    //    Instantiate(prefab, transform.position, transform.rotation);
    //    Debug.Log("Skill lanzada");
    //}
}
