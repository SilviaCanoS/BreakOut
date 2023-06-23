using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menuPausa, pelotaPrefab;
    private Pelota pelotaScript;

    public void MostrarMenuPausa()
    {
        menuPausa.SetActive(true);
        var pelota = Instantiate(pelotaPrefab) as GameObject;
        pelotaScript = pelota.GetComponent<Pelota>();
        
    }

    public void OcultarMenuPausa()
    {
        menuPausa.SetActive(false);
    }

    public void RegresarPantallaPrincipal()
    {
        SceneManager.LoadScene(0);
    }
}
