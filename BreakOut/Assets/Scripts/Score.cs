using System.Collections;
using System.Collections.Generic;
using TMPro;
//using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Score : MonoBehaviour
{
    public Transform transformMejorScore, transformScore;
    public TMP_Text textoMejorScore, textoScore;
    //public int intScore = 0, intMejorScore = 0;
    public MejorScore soVarScore;

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

        soVarScore.Cargar();
        textoMejorScore.text = $"Mejor Score: {soVarScore.score}";
        soVarScore.score = 0 ;
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

        textoScore.text = $"Score: {soVarScore.score}";
        if (soVarScore.score > soVarScore.mejorScore)
        {
            soVarScore.mejorScore = soVarScore.score;
            textoMejorScore.text = $"Mejor Score: {soVarScore.mejorScore}";
            soVarScore.Guardar();
        }
    }

    private void FixedUpdate()
    {
        soVarScore.score += 50;
    }
}
