using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    public MejorScore varScore;
    public Opciones opciones;
    //public GameObject bloque;
    public int resistencia = 1, puntos = 0;
    //public UnityEvent aumentarPuntaje;

    private void Start()
    {
        if (opciones.nivelDificultad == Opciones.Dificultad.dificil) resistencia = 2;
        puntos = resistencia * 100;
    }

    //se disparara cada que un objeto choque con el collider del gameObject
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pelota") RebotarPelota(collision);
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0)
        {
            //aumentarPuntaje.Invoke();
            AumentarScore();
            Destroy(this.gameObject);
        }
    }

    //virtual: las clases hijo pueden hacer una sobrecarga al metodo de la clase padre
    public virtual void RebotarPelota(Collision collision) 
    {
        //saca el vector (de la colision en el bloque al centro):
        Vector3 direccion = collision.contacts[0].point - transform.position; 
        direccion = direccion.normalized; //normaliza el vector
        //velocidad de la pelota
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Pelota>().velocidadPelota * direccion;
        resistencia--;
    }

    public void AumentarScore()
    {
        if (opciones.velocidadPelota <= 10) puntos = (int)Math.Round(puntos * 0.2);
        else if (opciones.velocidadPelota > 10 && opciones.velocidadPelota <= 20)
            puntos = (int)Math.Round(puntos * 0.4);
        else if (opciones.velocidadPelota > 20 && opciones.velocidadPelota <= 30)
            puntos = (int)Math.Round(puntos * 0.6);
        else if (opciones.velocidadPelota > 30 && opciones.velocidadPelota <= 40)
            puntos = (int)Math.Round(puntos * 0.8);
        else if (opciones.velocidadPelota > 40 && opciones.velocidadPelota <= 50)
            puntos = (int)Math.Round(puntos * 1.0);
        else if (opciones.velocidadPelota > 50 && opciones.velocidadPelota <= 60)
            puntos = (int)Math.Round(puntos * 1.2);
        else if (opciones.velocidadPelota > 60 && opciones.velocidadPelota <= 70)
            puntos = (int)Math.Round(puntos * 1.4);
        else if (opciones.velocidadPelota > 70 && opciones.velocidadPelota <= 80)
            puntos = (int)Math.Round(puntos * 1.6);
        else if (opciones.velocidadPelota > 80 && opciones.velocidadPelota <= 90)
            puntos = (int)Math.Round(puntos * 1.8);
        else if (opciones.velocidadPelota > 90) puntos = (int)Math.Round(puntos * 2.0);

        varScore.score += puntos;
    }
}
