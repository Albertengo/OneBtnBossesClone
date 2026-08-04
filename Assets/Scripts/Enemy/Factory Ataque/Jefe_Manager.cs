using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (canChangeATK)
        {
            StartCoroutine(Execute_ATK(3f));
        }
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
}
