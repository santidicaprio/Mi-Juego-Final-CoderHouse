using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // almacenar en un array o lista todos los obstaculos
    // en el obstaculo, guardar la posicion inicial
    // cuando toque una tecla, el gameManager va a ejecutar el resetObstacles, que lo que va a hacer es recorrer todos los obstaculos y reiniciarlos a su posicion inicial
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
