using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingFlow : MonoBehaviour
{
    public void ChangeScene()
    {
        FadeManager.Instance.LoadScene("Result", 2.0f);
    }
}