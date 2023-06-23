using System.Collections;
using System.Collections.Generic;
using TMPro;
//using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class ScoreMenuPrincipal : MonoBehaviour
{
    public Transform transformMejorScore;
    public TMP_Text textoMejorScore;
    //public int intScore = 0, intMejorScore = 0;
    public MejorScore nivel1, nivel2, nivel3;

    // Start is called before the first frame update
    void Start()
    {
        transformMejorScore = GameObject.Find("BestScore").transform;
        textoMejorScore = transformMejorScore.GetComponent<TMP_Text>();

        textoMejorScore.text = $"Mejor Score: {nivel1.mejorScore + nivel2.mejorScore + nivel3.mejorScore}";
    }

    public void Reset()
    {
        nivel1.mejorScore = 0;
        nivel2.mejorScore = 0;
        nivel3.mejorScore = 0;
        textoMejorScore.text = $"Mejor Score: {nivel1.mejorScore + nivel2.mejorScore + nivel3.mejorScore}";
    }
}
