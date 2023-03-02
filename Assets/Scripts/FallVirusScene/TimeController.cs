using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    private float timeLimit = 20.0f;

    [SerializeField] private Text timeText;

    void Update()
    {
        timeLimit -= Time.deltaTime;

        timeText.text = "Time : " + timeLimit.ToString("f1");

        if(timeLimit < 0)
        {
            timeText.text = "Time Up!";
        }
    }
}
