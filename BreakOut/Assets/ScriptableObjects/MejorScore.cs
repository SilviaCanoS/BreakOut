using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//va a aparecer en el menu con el boton derecho del mouse en la pestaña proyect, 0 = primer elemento
[CreateAssetMenu(fileName = "MejorScore", menuName = "Tools/MejorScore", order = 0)]

//tiene acceso a las funciones onEnable, onDisable, ...
public class MejorScore : ScorePersistente
{
    public int score = 0;
    public int mejorScore = 0;
}
