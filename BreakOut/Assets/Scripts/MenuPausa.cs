using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menuPausa, pelotaPrefab;
    public Pelota pelota;

    public void MostrarMenuPausa()
    {
        menuPausa.SetActive(true);   
    }

    public void OcultarMenuPausa()
    {
        menuPausa.SetActive(false);
        if(!pelota.isGameStarted) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void RegresarPantallaPrincipal()
    {
        SceneManager.LoadScene(0);
    }
}
