using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Opciones", menuName = "Tools/Opciones", order = 1)]

public class Opciones : ScorePersistente
{
    public float velocidadPelota = 30;
    public Dificultad nivelDificultad = Dificultad.facil;
    public enum Dificultad { facil, normal, dificil }

    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadPelota = nuevaVelocidad;
    }

    public void CambiarDificultad(int nuevaDificultad)
    {
        nivelDificultad = (Dificultad)nuevaDificultad;
    }
}
