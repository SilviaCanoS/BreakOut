using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderPelota : MonoBehaviour
{
    public Opciones opciones;
    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = this.GetComponent<Slider>();
        slider.value = opciones.velocidadPelota;
        slider.onValueChanged.AddListener(delegate { ControlarCambios(); });
    }

    public void ControlarCambios()
    {
        opciones.CambiarVelocidadPelota(slider.value);
    }
}
