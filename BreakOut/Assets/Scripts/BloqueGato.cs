using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueGato : Bloque //divide la pelota cuando se destruye
{
    GameObject spawnerPelota;

    // Start is called before the first frame update
    void Start()
    {
        resistencia = 2;
    }

    //private void Update()
    //{
    //    if (resistencia <= 0) 
    //    {
    //        GameObject tempPelota = Instantiate(spawnerPelota);
    //        Color c = new Color(Random.value, Random.value, Random.value);
    //        tempPelota.GetComponent<MeshRenderer>().material.color = c;
    //    }
    //}

    public override void RebotarPelota()
    {
        base.RebotarPelota();
    }
}
