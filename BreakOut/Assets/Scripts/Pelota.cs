using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public bool isGameStarted = false;
    [SerializeField] public float velocidadPelota = 20;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 posInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position; //le da la posicion del jugador
        posInicial.y += 2;
        this.transform.position = posInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform); //hace que se mueva con el jugador
    }

    // Update is called once per frame
    //input manager
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) || Input.GetButton("Submit")) //cuando se use la tecla espacio
        {
            if(!isGameStarted)
            {
                isGameStarted = true; //el juego empezo
                this.transform.SetParent(null); //quita al jugador como padre de la pelota
                GetComponent<Rigidbody>().velocity = velocidadPelota * Vector3.up; //poner la velocidad y mandar hacia arriba
            }
        }
    }
}
