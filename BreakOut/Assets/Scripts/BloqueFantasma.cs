using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class BloqueFantasma : Bloque //a veces se vuelve invisible y no se resta nada a su resistencia
{
    public GameObject imagenFantasma, menuPausa;
    float timer = 0, timerEfecto;
    
    // Start is called before the first frame update
    void Start()
    {
        timerEfecto = UnityEngine.Random.Range(1, 11);
        resistencia = 2;
        if (opciones.nivelDificultad == Opciones.Dificultad.facil) resistencia = 1;
        else if (opciones.nivelDificultad == Opciones.Dificultad.dificil) resistencia = 4;
    }

    private void Update()
    {
        if (resistencia <= 0)
        {
            aumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }

        timer += Time.deltaTime;
        if(timer >= timerEfecto)
        {
            timer = 0;
            timerEfecto = UnityEngine.Random.Range(1, 11);
            if(this.GetComponent<BoxCollider>().enabled)
            {
                this.GetComponent<MeshRenderer>().material.color = Color.black;
                this.GetComponent<BoxCollider>().enabled = false;
                if(!menuPausa.activeSelf) imagenFantasma.SetActive(true);
            }
            else
            {
                this.GetComponent<MeshRenderer>().material.color = Color.blue;
                this.GetComponent<BoxCollider>().enabled = true;
                imagenFantasma.SetActive(false);
            }

        }
    }

    public override void RebotarPelota(Collision collision)
    {
        base.RebotarPelota(collision);
    }
}
