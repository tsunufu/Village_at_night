using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ParticleMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private float time;

    //ゲームオーバー時にEscapeScoreManagerにアクセスしてスコアを記録できるように
    [SerializeField] private UnityEvent recordScore = new UnityEvent();

    private void Update()
    {
        time += Time.deltaTime;

        if (Mathf.Floor(time) % 30 == 0)
        {
            speed += 0.01f;
        }
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        print("衝突");
        recordScore.Invoke();
        FadeManager.Instance.LoadScene("Night", 2.0f);
        
    }

}
