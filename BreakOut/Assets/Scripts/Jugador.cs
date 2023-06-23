using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float timer = 0, timerEfecto = 10;
    Vector3 mousePos2D, mousePos3D; //nos da la posicion del mouse en 2D
    [SerializeField] public int limiteX = 24; //SerializeField hace que aparezca en el editor de unity
    [SerializeField] public float velocidadJugador = 30;
    new Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        transform = this.gameObject.transform;
    }

    // Update is called once per frame
    //todas las funciones del input manager se hacen en esta funcion
    void Update()
    {
        //mousePos2D = Input.mousePosition; //coordenadas x y y
        //mousePos2D.z = -Camera.main.transform.position.z; //coordenada z por medio de la camara

        ////pasarlo a coordenadas 3D para que pueda ser vista en la pantalla
        //mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        //manejar con el teclado,es down y up porque el objeto tiene una rotacion de 90° 
        //if (Input.GetKey(KeyCode.RightArrow))
        //    transform.Translate(Vector3.down *  velocidadJugador * Time.deltaTime);
        //else if (Input.GetKey(KeyCode.LeftArrow))
        //    transform.Translate(Vector3.up * velocidadJugador * Time.deltaTime);

        //manejar con control, joy stick o teclado; toma el eje horizontal del control
        transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * velocidadJugador * Time.deltaTime);

        //usar la información del mouse para mover el paddle del jugador, solo en el eje x
        Vector3 pos = transform.position; //obtiene la posicion del objeto 3D
        //pos.x = mousePos3D.x;

        //poner limites para que el mouse no se salga de la pantalla
        if (pos.x < -limiteX) pos.x = -limiteX; 
        else if(pos.x > limiteX) pos.x = limiteX;

        transform.position = pos;

        if(transform.localScale.y == 8)
        {
            timer += Time.deltaTime;
            if (timer >= timerEfecto)
            {
                timer = 0;
                this.GetComponent<Transform>().localScale = new Vector3(1, 4, 2);
                limiteX = 24;
                this.GetComponent<MeshRenderer>().material.color = Color.white;
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pelota")
        {
            //saca el vector (de la colision en el bloque al centro):
            Vector3 direccion = collision.contacts[0].point - transform.position;
            direccion = direccion.normalized; //normaliza el vector
            //velocidad de la pelota:
            collision.rigidbody.velocity = collision.gameObject.GetComponent<Pelota>().velocidadPelota * direccion;
        }
    }
}
