using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Resistencia : MonoBehaviour
{
    Transform transformResistencia;
    TMP_Text textoResistencia;
    public Bloque bloque;

    // Start is called before the first frame update
    void Start()
    {
        transformResistencia = this.transform;
        textoResistencia = transformResistencia.GetComponent<TMP_Text>();
        textoResistencia.text = bloque.resistencia.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textoResistencia.text = bloque.resistencia.ToString();
    }
}
