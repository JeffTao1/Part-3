using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject dog;
    public GameObject cat;
    public GameObject fox;

    // Start is called before the first frame update
    void Start()
    {

        int hmn = Random.Range(30, 100);
        for (int i = 0; i < hmn; i++)//make animals 
        {
            Instantiate(dog, new Vector2(Random.Range(7, -7), Random.Range(4, -4)), transform.rotation);//where they show up
            Instantiate(cat, new Vector2(Random.Range(7, -7), Random.Range(4, -4)), transform.rotation);//where they show up
            Instantiate(fox, new Vector2(Random.Range(7, -7), Random.Range(4, -4)), transform.rotation);//where they show up
        }



    }

}
