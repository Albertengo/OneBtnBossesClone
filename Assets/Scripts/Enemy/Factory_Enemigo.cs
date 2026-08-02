using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static Tipos_ATQ;

public class Factory_Enemigo : MonoBehaviour
{
    public ObjectPool bulletPool;
    public ObjectPool ConePool;

    public ISkill CreateAttack(AttackType type)
    {
        switch (type)
        {
            case AttackType.Shoot:
                return new Disparar(bulletPool);

            case AttackType.Cone:
                return new Cono_Ataque(ConePool);

            //case AttackType.Laser:
            //    return new LaserAttack(laserPool);

            default:
                return null;
        }
    }
}
