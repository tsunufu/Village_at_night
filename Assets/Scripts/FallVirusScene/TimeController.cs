using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TimeController : MonoBehaviour
{
    public float timeLimit = 20.0f;

    [SerializeField] private Text timeText;

    [SerializeField] private UnityEvent finalScore = new UnityEvent();

    private void Start()
    {
        StartCoroutine(ChangeResult());
    }

    void Update()
    {
        timeLimit -= Time.deltaTime;

        timeText.text = "Time : " + timeLimit.ToString("f1");

        if(timeLimit < 0)
        {
            timeText.text = "Time Up!";
            ChangeResult();

        }
    }

    //public void ChangeResult()
    //{
    //    FadeManager.Instance.LoadScene("Result", 2.0f);
    //    finalScore.Invoke();
    //}

    public IEnumerator ChangeResult()
    {
        yield return new WaitForSeconds(20.0f);

        FadeManager.Instance.LoadScene("Result", 2.0f);
        finalScore.Invoke();
    }

}
