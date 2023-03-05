using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : Character
{
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
        FadeManager.Instance.LoadScene("Night", 2.0f);
    }

}
