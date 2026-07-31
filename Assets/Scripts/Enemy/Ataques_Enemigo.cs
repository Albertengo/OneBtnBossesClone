using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Ataques_Enemigo : MonoBehaviour
{
    //script q va a heredar cada ataque del enemigo

    //[SerializeField] public ISkill_Enemigo[] skills;
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
            StartCoroutine(Cooldown_Skill());
    }
    public IEnumerator Cooldown_Skill()
    {
        can_skill = false;

        yield return new WaitForSeconds(cooldown_skill);

        //Instance_Skill();
        Execute_skill();
        Debug.Log("Skill ejecutada");

        can_skill = true;

        yield break;
    }

    public abstract void Execute_skill();

    /*
    protected void Instance_Skill()
    {
        Execute_skill();
        //RandomizeSkill();
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
    */

    //public void ExecuteSkill()
    //{
    //    if (can_skill) 
    //    {
    //        //Instance_Skill_Circle();
    //        Skill();
    //    }
    //}
}
