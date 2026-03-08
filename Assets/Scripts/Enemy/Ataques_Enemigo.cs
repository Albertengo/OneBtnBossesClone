using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Ataques_Enemigo : MonoBehaviour
{
    //script q va a heredar cada ataque del enemigo
    [SerializeField] float cooldown_skill;
    bool can_skill;


    void Update()
    {
        Execute_Skill();
    }
    IEnumerator Execute_Skill()
    {
        if (can_skill)
        {
            Instance_Skill_Circle();
            yield return new WaitForSeconds(cooldown_skill);
        }
    }

    //public void ExecuteSkill()
    //{
    //    if (can_skill) 
    //    {
    //        //Instance_Skill_Circle();
    //        Skill();
    //    }
    //}
    
    public void Instance_Skill_Circle()
    {
        Skill();

        //en este void poner algo de codigo q sirva para que la skill se invoque dentro del círculo
        //donde va a estar el player???????
    }
    public abstract void Skill();


}
