using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DropdownDificultad : MonoBehaviour
{
    public Opciones opciones;
    TMP_Dropdown dropdown;
    //Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        dropdown = this.GetComponent<TMP_Dropdown>();
        dropdown.value = (int)opciones.nivelDificultad;
        dropdown.onValueChanged.AddListener(delegate { opciones.CambiarDificultad(dropdown.value);
            IdentficarNivel(); });
    }

    public void IdentficarNivel()
    {
        if(SceneManager.GetActiveScene().buildIndex != 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
