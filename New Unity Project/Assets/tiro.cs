using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{
    float bala;

    public GameObject particula;

    // Start is called before the first frame update
    void Start()
    {
        bala = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(bala, 0, 0);

        if( transform.position.x > 50 || transform.position.x < -50 || transform.position.z > 50 || transform.position.z < -50)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider mata)
    {
        Debug.Log(mata.gameObject);

        if (mata.gameObject.tag == "Inimigo")
        {

            Destroy(Instantiate(particula, mata.transform.position,
                mata.transform.rotation), 0.6f);
            Destroy(mata.gameObject);
        }


    }


}
