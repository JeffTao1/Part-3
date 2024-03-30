using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementplayer : MonoBehaviour
{
    public GameObject home;
    public float speed ;
    bool arrived = false;
    Coroutine coroutine;
    
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButton(0) && coroutine == null) { 

            coroutine=StartCoroutine(YOUPAPA()); 
        }
    }
    IEnumerator YOUPAPA()
    {

            while (arrived)
            {
                transform.position = Vector2.MoveTowards(transform.position, home.transform.position, speed * Time.deltaTime);
                yield return null;
            }
            CALLING();
            yield return new WaitForSeconds(4);

    }
    protected virtual void CALLING()
    {

    }
    
}
