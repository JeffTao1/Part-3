using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class home : MonoBehaviour
{
    public GameObject homeing;
    // Start is called before the first frame update
    void Start()
    {
        homeing = GetComponent<movementplayer>().homet;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
