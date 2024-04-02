using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class one : movementplayer
{
     void Start()
    {
        homet = GameObject.Find("Homeone dog");
    }
    protected override void CALLING() // make the dog shouting
    {

        Debug.Log("wowow");
    }

}
