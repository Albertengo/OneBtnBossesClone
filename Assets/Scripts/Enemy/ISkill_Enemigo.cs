using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISkill//abstract class ISkill_Enemigo
{
    void execute_skill(Transform Firepoint);
    /*
    public virtual void execute_skill()
    {
        Debug.Log("me voy a morir");
    }
    */
}
