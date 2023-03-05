using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainningVillager : Character
{
    protected override void Talk()
    {
        if (timeState == TimeState.Morning)
        {
            chat.SendFungusMessage("TrainPenguinChat");
        }
        else if (timeState == TimeState.Night)
        {
            chat.SendFungusMessage("TrainPenguinChatAtNight");
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetMouseButtonDown(0))
            {
                Talk();
            }
        }
    }
}
