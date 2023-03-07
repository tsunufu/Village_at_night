using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //現時点でのスコアを毎回更新できるような変数
    private int score;
    public static int firstScore;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        score = EscapeScoreManager.middleScore;
        //スコア記録後は不要なので消す
        Destroy(GameObject.Find("EscapeScoreManager"));
        print(score);

        firstScore = score;
    }
}
