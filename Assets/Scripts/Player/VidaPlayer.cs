using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : Vida
{
    protected override void Death()
    {
        Debug.Log("Perdiste");
    }

}
