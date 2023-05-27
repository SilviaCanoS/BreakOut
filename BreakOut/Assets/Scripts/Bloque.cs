using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    public GameObject bloque;
    public int resistencia = 1; //resistencia = 1: se destruye al primer contacto

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0) Destroy(this.gameObject);
    }

    public virtual void RebotarPelota() //virtual: las clases hijo pueden hacer una sobrecarga al metodo de la clase padre
    {
        
    }
}
