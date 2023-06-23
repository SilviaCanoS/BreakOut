using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class BloqueGoma : Bloque //alarga el jugador
{
    public Jugador jugador;

    // Start is called before the first frame update
    void Start()
    {
        resistencia = 4;
        if (opciones.nivelDificultad == Opciones.Dificultad.facil) resistencia = 1;
        else if (opciones.nivelDificultad == Opciones.Dificultad.dificil) resistencia = 8;
        transformResistencia = GameObject.Find("ResistenciaGoma").transform;
        textoResistencia = transformResistencia.GetComponent<TMP_Text>();
        textoResistencia.text = resistencia.ToString();
    }

    private void Update()
    {
        textoResistencia.text = resistencia.ToString();
        if (resistencia <= 0)
        {
            aumentarPuntaje.Invoke();
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
