using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementplayer : MonoBehaviour
{
    public GameObject homet;
    public float speed ;
    bool arrived = false;
    Coroutine coroutine;
    
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButton(0) && coroutine == null) { //when pressed mouse then it move

            coroutine=StartCoroutine(YOUPA()); // after pressed it will start working on the youpa
        }
    }
    IEnumerator YOUPA()
    {

            while (arrived==false)
            {
                transform.position = Vector2.MoveTowards(transform.position, homet.transform.position, speed * Time.deltaTime);
                if((homet.transform.position - transform.position).magnitude < 0.1)//when the animals is arrived then they will shouting
            {
                    arrived = true;
                mark.setmark(mark.Mark + 1);// and record how many animals there are
            }
                yield return null;
            }
            CALLING();
            

    }
    protected virtual void CALLING()
    {

    }
    
}
