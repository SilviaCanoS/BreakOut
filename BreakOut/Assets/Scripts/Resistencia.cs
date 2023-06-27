using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Resistencia : MonoBehaviour
{
    TMP_Text textoResistencia;
    Bloque bloque;

    // Start is called before the first frame update
    void Start()
    {
        //textoResistencia = gameObject.GetComponent<TMP_Text>(); //acceder desde cualquier GO
        //textoResistencia = this.GetComponent<TMP_Text>(); //acceder directamente del mismo objeto
        //textoResistencia = GetComponent<TMP_Text>(); //esta directamennte relacionao con el GO que tiene el script
        textoResistencia = GetComponentInChildren<TMP_Text>();
        bloque = GetComponent<Bloque>();
    }

    // Update is called once per frame
    void Update()
    {
        textoResistencia.text = bloque.resistencia.ToString();
    }
}
