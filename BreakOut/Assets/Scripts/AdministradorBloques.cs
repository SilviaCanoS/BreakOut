using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorBloques : MonoBehaviour
{
    public GameObject menuFinNivel;

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            menuFinNivel.SetActive(true);
        }
    }
}
