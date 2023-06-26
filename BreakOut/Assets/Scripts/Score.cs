using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
//using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;

public class Score : MonoBehaviour
{
    public Transform transformMejorScore, transformScore;
    public TMP_Text textoMejorScore, textoScore;
    //public int intScore = 0, intMejorScore = 0;
    public MejorScore varScore;

    // Start is called before the first frame update
    void Start()
    {
        transformScore = GameObject.Find("Score").transform;
        transformMejorScore = GameObject.Find("BestScore").transform;
        textoScore = transformScore.GetComponent<TMP_Text>();
        textoMejorScore = transformMejorScore.GetComponent<TMP_Text>();

        //if (PlayerPrefs.HasKey("BestScore")) //sirve para guardar el score para futuras partidas
        //{
        //    intMejorScore = PlayerPrefs.GetInt("BestScore");
        //    textoMejorScore.text = $"Mejor Score: {intMejorScore }";
        //}

        varScore.Cargar();
        textoMejorScore.text = $"Mejor Score: {varScore.mejorScore}";
        varScore.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //textoScore.text = $"Score: {intScore}";
        //if(intScore > intMejorScore)
        //{
        //    intMejorScore = intScore;
        //    textoMejorScore.text = $"Mejor Score: {intMejorScore}";
        //    PlayerPrefs.SetInt("BestScore", intScore);
        //}

        textoScore.text = $"Score: {varScore.score}";
        textoMejorScore.text = $"Mejor Score: {varScore.mejorScore}";
        if (varScore.score > varScore.mejorScore) varScore.mejorScore = varScore.score;
        varScore.Guardar();
    }

    //private void FixedUpdate()
    //{
    //    soVarScore.score += 50;
    //}
}
