using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BloqueFantasma : Bloque //a veces se vuelve invisible y no se resta nada a su resistencia
{
    
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 2;
    }

    //private void Update()
    //{
    //    while (resistencia !=0) 
    //    {
    //        Thread.Sleep(5000); //15 segundos
    //        bloque.GetComponent<BoxCollider>().enabled = false;

    //        Thread.Sleep(5000); //15 segundos
    //        bloque.GetComponent<BoxCollider>().enabled = true;
    //    }
    //}

    public override void RebotarPelota()
    {
        base.RebotarPelota();
    }
}
