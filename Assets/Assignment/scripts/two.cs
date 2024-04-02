using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class two : movementplayer
{
     void Start()
    {
        homet = GameObject.Find("Homeone cat");
    }
    protected override void CALLING()
    {

        Debug.Log("MOMOMO"); // make the cat shouting
    }
}
