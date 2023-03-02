using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyStage());
    }


    private IEnumerator DestroyStage()
    {
        yield return null;
    }
}
