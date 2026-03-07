using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class VidaEnemigo : Vida
{
    protected override void Death()
    {
        Destroy(gameObject);
        GameManager.managerInstance.activatePanel(GameManager.managerInstance.Victory_UI);
    }

}
