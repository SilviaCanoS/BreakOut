using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    public Opciones opciones;
    //public GameObject bloque;
    public int resistencia = 1; //resistencia = 1: se destruye al primer contacto
    public UnityEvent aumentarPuntaje;

    private void Start()
    {
        if (opciones.nivelDificultad == Opciones.Dificultad.dificil) resistencia = 2;
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
            aumentarPuntaje.Invoke();
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
}
