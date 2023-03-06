using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] private GameObject leftObstacle;
    [SerializeField] private GameObject rightObstacle;

    //障害物を右と左どちらに配置するか．1だと右，0だと左
    private int randomInstantiate;
    private float interval = 3.0f;
    private int generateCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateStage(interval));
    }


    private IEnumerator CreateStage(float interval)
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            randomInstantiate = Random.Range(0,2);
            if (randomInstantiate == 0)
            {
                Instantiate(leftObstacle, new Vector3(leftObstacle.transform.position.x + (generateCount * 50), leftObstacle.transform.position.y, leftObstacle.transform.position.z), Quaternion.identity);
                generateCount++;
            }
            else if(randomInstantiate == 1)
            {
                Instantiate(rightObstacle, new Vector3(rightObstacle.transform.position.x + (generateCount * 50), rightObstacle.transform.position.y, rightObstacle.transform.position.z), Quaternion.identity);
                generateCount++;
            }
        }
    }
}
