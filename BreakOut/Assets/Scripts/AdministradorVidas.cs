using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorVidas : MonoBehaviour
{
    [HideInInspector] public List<GameObject> vidas; //es publica pero no se muestra en el inspector
    public GameObject pelotaPrefab, menuGameOver;
    private Pelota pelotaScript;

    // Start is called before the first frame update
    void Start()
    {
        Transform[] hijos = GetComponentsInChildren<Transform>();
        foreach (Transform t in hijos) vidas.Add(t.gameObject);
    }

    public void EliminarVida()
    {
        var objetoAEliminar = vidas[vidas.Count - 1];
        Destroy(objetoAEliminar);
        vidas.RemoveAt(vidas.Count - 1);
        if(vidas.Count <= 0)
        {
            menuGameOver.SetActive(true);
            return;
        }

        var pelota = Instantiate(pelotaPrefab) as GameObject;
        pelotaScript = pelota.GetComponent<Pelota>();
        pelotaScript.pelotaDestruida.AddListener(this.EliminarVida);
        Debug.Log("Vidas restantes: " + vidas.Count);
    }
}
