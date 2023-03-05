using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void ChangeNight()
    {

    }

}
