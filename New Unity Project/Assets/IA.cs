using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class IA : MonoBehaviour
{     
    void Update()
    {
        GetComponent<NavMeshAgent>().SetDestination  
          (GameObject.FindGameObjectWithTag
          ("Player").transform.position);
    }
}
