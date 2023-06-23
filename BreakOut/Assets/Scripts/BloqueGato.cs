using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BloqueGato : Bloque //divide la pelota cuando se destruye
{
    public GameObject pelotaPrefab;
    private Pelota pelotaScript;

    // Start is called before the first frame update
    void Start()
    {
        resistencia = 2;
        if (opciones.nivelDificultad == Opciones.Dificultad.facil) resistencia = 1;
        else if (opciones.nivelDificultad == Opciones.Dificultad.dificil) resistencia = 4;
        transformResistencia = GameObject.Find("ResistenciaGato").transform;
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

            var pelota = Instantiate(pelotaPrefab) as GameObject;
            pelotaScript = pelota.GetComponent<Pelota>();
            Color c = new Color(Random.value, Random.value, Random.value);
            pelota.GetComponent<MeshRenderer>().material.color = c;
        }
    }

    public override void RebotarPelota(Collision collision)
    {
        base.RebotarPelota(collision);
    }
}
