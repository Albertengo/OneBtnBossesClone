using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static Tipos_ATQ;

public class Jefe_Manager : MonoBehaviour
{
    public Factory_Enemigo factory;
    public Transform firePoint;
    bool canChangeATK;

    public void Awake()
    {
        canChangeATK = true;
    }

    public void FixedUpdate()
    {
        if (canChangeATK) //NO NUEVO
        {
            StartCoroutine(Execute_ATK(3f));
        }
        //SkillRandomizer();
    }
    void SkillRandomizer()
    {
        AttackType attack = (AttackType)Random.Range(0, 4);

        factory.CreateAttack(attack).execute_skill(firePoint);
    }

    private IEnumerator Execute_ATK(float seconds)
    {
        SkillRandomizer();

        canChangeATK = false;
        yield return new WaitForSeconds(seconds);
        canChangeATK = true;
    }
    //void Attack()
    //{
    //    ISkill attack =
    //        factory.CreateAttack(AttackType.Cone);

    //    attack.execute_skill(firePoint);
    //    //attack.Execute(firePoint);
    //}
}
