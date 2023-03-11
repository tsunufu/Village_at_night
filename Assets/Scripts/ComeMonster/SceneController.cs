using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public void ChangeScene()
    {
        FadeManager.Instance.LoadScene("Night", 2.0f);
    }
}
