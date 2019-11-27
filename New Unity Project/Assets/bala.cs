using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public GameObject myPrefab;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Time.timeScale == 1)
            {

                Instantiate(myPrefab, transform.position, transform.rotation);


            }

        }
    }

}