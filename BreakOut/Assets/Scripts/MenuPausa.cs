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
        //menuPausa.GetComponent<Transform>().Translate(Input.GetAxis("Horizontal") * Vector3.down * Time.deltaTime);
        Time.timeScale = 0;
    }

    public void OcultarMenuPausa()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1;
        if(!pelota.isGameStarted) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void RegresarPantallaPrincipal()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
