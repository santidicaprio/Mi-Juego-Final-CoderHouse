using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;
    public Obstacle[] obstaclesArray;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    void Start()
    {
        //obstaclesArray[0].DeactiveKinematic();
    }

    
    void Update()
    {
        
    }

    public void ResetObstacles()
    {

    }
}
