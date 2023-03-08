using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScoreManager : MonoBehaviour
{
    private int finalScore;
    //ハイスコアを記録しておく変数
    private int highscore;

    [SerializeField] private Text currentScoreText;
    [SerializeField] private Text highScoreText;

    private void Start()
    {
        finalScore = VirusScoreManager.finalScore;
        currentScoreText.text = "SCORE : " + finalScore.ToString();

        //今までのハイスコアをもってくる
        highscore = PlayerPrefs.GetInt("SCORE", highscore);

        if(highscore < finalScore)
        {
            PlayerPrefs.SetInt("SCORE", finalScore);
            PlayerPrefs.Save();
            highscore = PlayerPrefs.GetInt("SCORE", highscore);
        }

        highScoreText.text = "HIGHSCORE : " + highscore.ToString();
    }

}
