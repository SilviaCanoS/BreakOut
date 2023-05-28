using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; //permite acceder al disco duro de la computadora
using System.Runtime.Serialization.Formatters.Binary; //crea un archivo binario del archivo de guardado
using Unity.VisualScripting;

public abstract class ScorePersistente : ScriptableObject
{
    //json es un lenguaje que comunica diferentes tipos de lenguajes, crea un objeto y lo manda a otros servicios
    public void Guardar(string nombreArchivo = null)
    {
        var bf = new BinaryFormatter();
        var file = File.Create(ObtenerRuta(nombreArchivo));
        var json = JsonUtility.ToJson(this);

        bf.Serialize(file, json);
        file.Close();
    }

    public virtual void Cargar(string nombreArchivo = null)
    {
        if(File.Exists(ObtenerRuta(nombreArchivo)))
        {
            var bf = new BinaryFormatter();
            var archivo = File.Open(ObtenerRuta(nombreArchivo), FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(archivo), this); //recibe el nombre del archivo y que objeto va a guardar esos datos
            archivo.Close();
        }
    }

    public string ObtenerRuta(string nombreArchivo = null)
    {
        var nombreArchivoCompleto = string.IsNullOrEmpty(nombreArchivo) ? name : nombreArchivo;
        return string.Format("{0}/{1}.silvia", Application.persistentDataPath, nombreArchivoCompleto);
    }
}
