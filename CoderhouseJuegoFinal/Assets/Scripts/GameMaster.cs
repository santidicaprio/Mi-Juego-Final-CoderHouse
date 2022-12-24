using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster instance;
    public Vector3 lastCheckPointPos;
    
    
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);


        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void ResetCheckpoint()
    {
        lastCheckPointPos.z = 1706.9f;
    }
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
