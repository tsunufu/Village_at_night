using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : Character
{
    [SerializeField] private SoundManager soundManager;
    
    private float interval = 0.01f;

    protected override void Talk()
    {
        if (timeState == TimeState.Morning)
        {
            chat.SendFungusMessage("BeeReady");
        }
        else if (timeState == TimeState.Night)
        {

        }

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Talk();
        }
    }

    protected override void ChangeScene()
    {
        print("aaavvv");
        StartCoroutine(soundManager.VolumeDown(interval));
        FadeManager.Instance.LoadScene("ComeMonster", 2.0f);
    }

}
