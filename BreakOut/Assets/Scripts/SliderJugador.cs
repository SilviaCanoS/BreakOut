using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderJugador : MonoBehaviour
{
    public Opciones opciones;
    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = this.GetComponent<Slider>();
        slider.value = opciones.velocidadJugador;
        slider.onValueChanged.AddListener(delegate { ControlarCambiosJugador(); });
    }

    public void ControlarCambiosJugador()
    {
        opciones.CambiarVelocidadJugador(slider.value);
    }
}
