using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pelota : MonoBehaviour
{
    public bool isGameStarted = false;
    [SerializeField] public float velocidadPelota = 25;

    Vector3 ultimaPosiciom = Vector3.zero;
    Vector3 direccion = Vector3.zero;
    new Rigidbody rigidbody;
    private LimitesPantalla control;
    public UnityEvent pelotaDestruida;
    public Opciones opciones;

    private void Awake()
    {
        control = GetComponent<LimitesPantalla>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector3 posInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position; //le da la posicion del jugador
        posInicial.y += 2;
        this.transform.position = posInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform); //hace que se mueva con el jugador
        rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //input manager
    void Update()
    {
        velocidadPelota = opciones.velocidadPelota;

        //en caso de que la pelota se salga por el borde inferior
        if (control.salioAbajo)
        {
            //Debug.Log("La pelota toco el borde inferior");
            pelotaDestruida.Invoke();
            Destroy(this.gameObject);
        }

        //en caso de que la pelota se salga por el borde superior
        if (control.salioArriba)
        {
            direccion = transform.position - ultimaPosiciom;
            //Debug.Log("La pelota toco el borde superior");
            direccion.y *= -1;
            direccion = direccion.normalized;
            rigidbody.velocity = velocidadPelota * direccion;
            control.salioArriba = false;
            control.enabled = false;
            Invoke("HabilitarControl", .05f);
        }

        //en caso de que la pelota se salga por el borde derecho
        if (control.salioDerecha)
        {
            direccion = transform.position - ultimaPosiciom;
            //Debug.Log("La pelota toco el borde derecho");
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidbody.velocity = velocidadPelota * direccion;
            control.salioDerecha = false;
            control.enabled = false;
            Invoke("HabilitarControl", .05f);
        }

        //en caso de que la pelota se salga por el borde izquierdo
        if (control.salioIzquierda)
        {
            direccion = transform.position - ultimaPosiciom;
            //Debug.Log("La pelota toco el borde izquierdo");
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidbody.velocity = velocidadPelota * direccion;
            control.salioIzquierda = false;
            control.enabled = false;
            Invoke("HabilitarControl", .05f);
        }

        if (Input.GetKeyUp(KeyCode.Space) || Input.GetButton("Submit")) //cuando se use la tecla espacio
        {
            if (!isGameStarted)
            {
                isGameStarted = true; //el juego empezo
                this.transform.SetParent(null); //quita al jugador como padre de la pelota
                GetComponent<Rigidbody>().velocity = velocidadPelota * Vector3.up; //poner la velocidad y mandar hacia arriba
            }
        }
    }

    private void HabilitarControl()
    {
        control.enabled = true;
    }

    //se hace en esta funcion para que tenga una posicion diferente a la que hay en update
    private void FixedUpdate()
    {
        ultimaPosiciom = transform.position;
    }

    //reinicializar la variable direccion
    private void LateUpdate()
    {
        if (direccion != Vector3.zero) direccion = Vector3.zero;
    }

    public void Destruir ()
    {
        Destroy(this.gameObject);
    }
}
