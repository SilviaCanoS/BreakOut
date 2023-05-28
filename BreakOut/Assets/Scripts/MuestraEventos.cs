using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MuestraEventos : MonoBehaviour
{
    public event EventHandler onEspacioPresionado;
    public UnityEvent miEventoUnity;

    // Start is called before the first frame update
    void Start()
    {
        onEspacioPresionado += EventoEscuchado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onEspacioPresionado?.Invoke(this, EventArgs.Empty);
            miEventoUnity.Invoke();
        }
    }

    public void EventoEscuchado(object sender, EventArgs e)
    {
        Debug.Log("El evento se escucho correctamente");
    }

    public void EventoUnity()
    {
        Debug.Log("El evento de Unity se disparo correctamente");
    }
}
