using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    [SerializeField] private GameObject enemy;

    private void Update()
    {
        if (enemy.transform.position.y < -4)
        {
            if (enemy != null)
            {
                Destroy(enemy);
            }
        }
    }
}
