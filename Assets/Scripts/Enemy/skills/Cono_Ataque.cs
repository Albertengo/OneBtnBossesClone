using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cono_Ataque : MonoBehaviour, ISkill_Enemigo//Ataques_Enemigo, ISkill_Enemigo
{
    public GameObject prefab;

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

    public void skill()
    {
        Instantiate(prefab, transform.position, transform.rotation);
        Debug.Log("Skill lanzada");
    }
}
