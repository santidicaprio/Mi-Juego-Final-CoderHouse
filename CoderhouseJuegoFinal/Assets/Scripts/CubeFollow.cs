using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFollow : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] GameObject sphere;
    void Start()
    {

    }


    void Update()
    {

        transform.Translate(-transform.forward * Time.deltaTime * speed);

    }


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.transform.tag == "Sphere")
        {
            Destroy(sphere);
        }
        
        
    }
}

