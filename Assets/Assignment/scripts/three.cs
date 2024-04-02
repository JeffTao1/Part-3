using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class three : movementplayer
{
     void Start()
    {
        homet = GameObject.Find("Homeone fox");
    }
    protected override void CALLING()
    {

        Debug.Log("FOFOFO");// make the fox shouting
    }
}
