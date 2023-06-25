using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BloquePiedra : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 5;
        if (opciones.nivelDificultad == Opciones.Dificultad.facil) resistencia = 1;
        else if (opciones.nivelDificultad == Opciones.Dificultad.dificil) resistencia = 10;
    }

    private void Update()
    {
        if (resistencia <= 0)
        {
            aumentarPuntaje.Invoke();
            Destroy(this.gameObject);

        }
    }

    public override void RebotarPelota(Collision collision) //herencia
    {
        base.RebotarPelota(collision);
    }
}
