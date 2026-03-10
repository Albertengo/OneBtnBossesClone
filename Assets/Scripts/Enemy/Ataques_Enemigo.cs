using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ataques_Enemigo : MonoBehaviour
{
    //script q va a heredar cada ataque del enemigo
    //private Action[] skills;
    [SerializeField] private ISkill_Enemigo[] skills;
    [SerializeField] protected float cooldown_skill;
    bool can_skill;

    protected void Start()
    {
        can_skill = true;
        //ISkill_Enemigo skills = FindObjectOfType<ISkill_Enemigo()>;
        //GetComponent.Add.this();
    }

    protected void Update()
    {
        if (can_skill)
            StartCoroutine(Execute_Skill());
    }
    IEnumerator Execute_Skill()
    {
        can_skill = false;

        yield return new WaitForSeconds(cooldown_skill);
        Instance_Skill();
        Debug.Log("Skill ejecutada");
        can_skill = true;
        yield break;
    }

    //public void ExecuteSkill()
    //{
    //    if (can_skill) 
    //    {
    //        //Instance_Skill_Circle();
    //        Skill();
    //    }
    //}
    
    protected void Instance_Skill()
    {
        RandomizeSkill();
        Debug.Log("Skill instanciada");
        //en este void poner algo de codigo q sirva para que la skill se invoque dentro del círculo
        //donde va a estar el player???????
    }
    protected void RandomizeSkill()
    {
        int RandomValue = UnityEngine.Random.Range(0, skills.Length);
        skills[RandomValue].skill();
        Debug.Log("Skill randomizada/elegida");
    }


}
