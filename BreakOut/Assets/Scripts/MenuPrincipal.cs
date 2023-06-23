using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject menuOpciones, menuInicial;

    public void IniciarJuego()
    {
        SceneManager.LoadScene(1);
    }

    public void FinalizarJuego()
    {
        Application.Quit();
    }

    public void MostrarMenuOpciones()
    {
        menuInicial.SetActive(false);
        menuOpciones.SetActive(true);
    }

    public void MostrarMenuInicial()
    {
        menuInicial.SetActive(true);
        menuOpciones.SetActive(false);
    }
}
