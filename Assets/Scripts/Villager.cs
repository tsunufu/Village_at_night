using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Villager : Character
{

    protected override void Talk()
    {
        chat.SendFungusMessage("PenguinChat1");
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
