using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeScoreManager : MonoBehaviour
{
    private int score;
    private float interval = 2.0f;
    [SerializeField] private Text scoreText;
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
        scoreText.text = "SCORE : " + score.ToString();
    }
}
