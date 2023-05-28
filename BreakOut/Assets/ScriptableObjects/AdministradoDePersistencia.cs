using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradoDePersistencia : MonoBehaviour
{
    public List<ScorePersistente> objetosAGuardar;

    private void OnEnable()
    {
        for(int i = 0; i <= objetosAGuardar.Count - 1; i++)
        {
            var so = objetosAGuardar[i];
            so.Cargar();
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i <= objetosAGuardar.Count - 1; i++)
        {
            var so = objetosAGuardar[i];
            so.Guardar();
        }
    }
}
