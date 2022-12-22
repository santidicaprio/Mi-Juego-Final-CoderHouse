using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip music;

    void Start()
    {
        audioSource.PlayOneShot(music);
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.transform.CompareTag("FinishGame"))
        {
            audioSource.Stop();
        }
    }
}
