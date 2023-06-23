using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BloqueMadera : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 3;
        if (opciones.nivelDificultad == Opciones.Dificultad.facil) resistencia = 1;
        else if (opciones.nivelDificultad == Opciones.Dificultad.dificil) resistencia = 6;
        transformResistencia = GameObject.Find("ResistenciaMadera").transform;
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

        }
    }

    public override void RebotarPelota(Collision collision)
    {
        base.RebotarPelota(collision);
    }
}
