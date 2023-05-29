using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Margenes : Bloque
{
    void Start()
    {
        resistencia = 99999;
    }

    public override void RebotarPelota(Collision collision)
    {
        base.RebotarPelota(collision);
    }
}
