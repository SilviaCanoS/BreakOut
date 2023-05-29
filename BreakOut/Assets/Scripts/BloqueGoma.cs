using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueGoma : Bloque //alarga el jugador
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 4; 
    }

    public override void RebotarPelota(Collision collision)
    {
        base.RebotarPelota(collision);
    }
}
