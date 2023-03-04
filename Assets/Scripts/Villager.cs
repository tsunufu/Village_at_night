using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Villager : Character
{

    protected override void Talk()
    {
        if (timeState == TimeState.Morning)
        {
            chat.SendFungusMessage("PenguinChat1");
        }
        else if(timeState == TimeState.Night)
        {

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