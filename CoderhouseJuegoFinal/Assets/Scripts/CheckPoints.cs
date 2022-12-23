using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{          
    private GameMaster gm;
    
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }


    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Sphere"))
        {
            gm.lastCheckPointPos = transform.position;
        }
        
    }
}
