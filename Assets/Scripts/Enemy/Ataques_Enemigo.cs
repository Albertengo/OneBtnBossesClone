using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//public abstract class Ataques_Enemigo : MonoBehaviour
//{
//    [SerializeField] protected float cooldown_skill;
//    bool can_skill;

//    protected void Start()
//    {
//        can_skill = true;
//    }

//    protected void Update()
//    {
//        if (can_skill)
//            StartCoroutine(Cooldown_Skill());
//    }
//    public IEnumerator Cooldown_Skill()
//    {
//        can_skill = false;

//        yield return new WaitForSeconds(cooldown_skill);

//        Execute_skill();
//        Debug.Log("Skill ejecutada");

//        can_skill = true;

//        yield break;
//    }

//    public abstract void Execute_skill();
//}
