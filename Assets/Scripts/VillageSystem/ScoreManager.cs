using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //現時点でのスコアを毎回更新できるような変数
    private int score;
    private GameObject escapeScoreManager;

    private void Start()
    {
        score = EscapeScoreManager.middleScore;
        print(score);
    }
}
