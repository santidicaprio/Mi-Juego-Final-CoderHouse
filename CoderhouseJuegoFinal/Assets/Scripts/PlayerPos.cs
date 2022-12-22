using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;
    [SerializeField] AudioSource deadSound;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPointPos;

    }


    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Dead"))
        {
            deadSound.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }




}
