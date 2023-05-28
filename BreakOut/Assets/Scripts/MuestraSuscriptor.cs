using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuestraSuscriptor : MonoBehaviour
{
    MuestraEventos suscriptor;

    // Start is called before the first frame update
    void Start()
    {
        suscriptor = GetComponent<MuestraEventos>();
        suscriptor.onEspacioPresionado += MensajeEscuchado;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MensajeEscuchado(object sender, EventArgs e)
    {
        Debug.Log("Evento escuchado desde otra clase");
        suscriptor.onEspacioPresionado -= MensajeEscuchado;
    }
}
