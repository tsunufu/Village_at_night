using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    private float interval = 1.0f;

    private void Start()
    {
        StartCoroutine(CreateEnemy(interval));
    }

    private IEnumerator CreateEnemy(float interval)
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            Instantiate(enemy, new Vector3(Random.Range(-6.5f, 6.5f), 7, -1.5f), Quaternion.Euler(0, 180, 0));
        }
    }


}
