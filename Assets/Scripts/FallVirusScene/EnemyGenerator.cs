using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    private float interval = 1.0f;
    private float fastInterval = 0.5f;
    [SerializeField] private TimeController timeController;

    private void Start()
    {
        StartCoroutine(CreateEnemy(interval));
        StartCoroutine(MoreCreateEnemy(fastInterval));
    }

    private IEnumerator CreateEnemy(float interval)
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            Instantiate(enemy, new Vector3(Random.Range(-6.5f, 6.5f), 7, -1.5f), Quaternion.Euler(0, 180, 0));
        }
    }

    //制限時間によって敵の生成速度を増やす
    private IEnumerator MoreCreateEnemy(float fastInterval)
    {
        while (true)
        {
            yield return new WaitForSeconds(fastInterval);
            if(timeController.timeLimit < 15.0f)
            {
                Instantiate(enemy, new Vector3(Random.Range(-6.5f, 6.5f), 7, -1.5f), Quaternion.Euler(0, 180, 0));
                //最後はさらに増やす
                if (timeController.timeLimit < 10.0f)
                {
                    Instantiate(enemy, new Vector3(Random.Range(-6.5f, 6.5f), 7, -1.5f), Quaternion.Euler(0, 180, 0));
                    if (timeController.timeLimit < 5.0f)
                    {
                        Instantiate(enemy, new Vector3(Random.Range(-6.5f, 6.5f), 7, -1.5f), Quaternion.Euler(0, 180, 0));
                    }
                }
            }
        }
    }



}
