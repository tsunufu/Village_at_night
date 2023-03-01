using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour
{
    [SerializeField] private GameObject stage;

    private float interval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateStage(interval));
    }


    private IEnumerator CreateStage(float interval)
    {
        yield return new WaitForSeconds(interval);
        Instantiate(stage, new Vector3(stage.transform.position.x + 50, stage.transform.position.y, stage.transform.position.z), Quaternion.identity);
    }
}
