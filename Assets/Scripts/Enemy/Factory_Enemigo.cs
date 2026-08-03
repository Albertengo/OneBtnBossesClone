using UnityEngine;

public class Factory_Enemigo : MonoBehaviour
{
    public ObjectPool bulletPool;
    public ObjectPool ConePool;
    public ObjectPool BarPool;

    public ISkill CreateAttack(AttackType type)
    {
        switch (type)
        {
            case AttackType.Shoot:
                return new Disparar(bulletPool);

            case AttackType.Cone:
                return new Cono_Ataque(ConePool);

            case AttackType.Bar:
                return new Barra_Ataque(BarPool);

            default:
                return null;
        }
    }
}
