using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeScoreManager : MonoBehaviour
{
    private int score;
    //スコアの加算間隔
    private float interval = 2.0f;
    //中間スコアをstaticな変数で保存
    public static int middleScore;

    [SerializeField] private Text scoreText;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        StartCoroutine(AddScore(interval));
    }


    private IEnumerator AddScore(float interval)
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            score++;
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "SCORE: " + score.ToString();
        }
    }

    public void RecordScore()
    {
        middleScore = score;
        print(middleScore);
    }

}
