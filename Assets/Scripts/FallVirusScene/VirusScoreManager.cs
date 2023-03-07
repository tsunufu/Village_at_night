using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusScoreManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private int myScore;
    //ゲーム記録用のスコア
    public int score;
    public static int finalScore;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        myScore = ScoreManager.firstScore;
        score = myScore;
        print(myScore);
        scoreText.text = "SCORE : " + score.ToString();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "SCORE : " + score.ToString();
    }

    public void FinalScore()
    {
        finalScore = score;
        print(finalScore);
    }

}
