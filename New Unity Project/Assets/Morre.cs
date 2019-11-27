using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morre : MonoBehaviour
{

    void OnCollisionEnter(Collision Collide)
    {
        if(Collide.gameObject.tag == "tiro")
        {
            Destroy(gameObject);
        }
    }   

}
