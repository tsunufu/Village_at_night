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

    [SerializeField] private SoundManager soundManager;

    private float interval = 0.01f;

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

        StartCoroutine(soundManager.VolumeDown(interval));
        FadeManager.Instance.LoadScene("Ending", 2.0f);
        finalScore.Invoke();
    }

}
