using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BloqueGoma : Bloque //alarga el jugador
{
    public Jugador jugador;

    // Start is called before the first frame update
    void Start()
    {
        resistencia = 4;
        if (opciones.nivelDificultad == Opciones.Dificultad.facil) resistencia = 1;
        else if (opciones.nivelDificultad == Opciones.Dificultad.dificil) resistencia = 8;
        puntos = resistencia * 100;
    }

    private void Update()
    {
        if (resistencia <= 0)
        {
            AumentarScore();
            //aumentarPuntaje.Invoke();
            Destroy(this.gameObject);

            jugador.GetComponent<Transform>().localScale = new Vector3(1, 8, 2);
            jugador.limiteX = 20;
            Color c = new Color(Random.value, Random.value, Random.value);
            jugador.GetComponent<MeshRenderer>().material.color = c;
        }
    }

    public override void RebotarPelota(Collision collision)
    {
        base.RebotarPelota(collision);
    }
}
