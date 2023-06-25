using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausarJuego : MonoBehaviour
{
    public GameObject menuCompletado, menuPausa, menuGameOver;

    // Update is called once per frame
    void Update()
    {
        if (menuCompletado.activeSelf || menuGameOver.activeSelf || menuPausa.activeSelf) Time.timeScale = 0;
        else Time.timeScale = 1;
    }
}
