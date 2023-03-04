using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public enum TimeState
{
    Morning,
    Night
}

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected Flowchart chat = null;
    protected TimeState timeState;

    protected void Start()
    {
        //朝か夜かの判定
        if(SceneManager.GetActiveScene().name == "Morning")
        {
            timeState = TimeState.Morning;
        }
        else if(SceneManager.GetActiveScene().name == "Night")
        {
            timeState = TimeState.Night;
        }
    }

    protected abstract void Talk();

}
