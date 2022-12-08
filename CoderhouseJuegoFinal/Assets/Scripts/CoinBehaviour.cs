using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    
    
    
    
    private int _coinSummary = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Coin()
    {
        _coinSummary += 1;        
        Debug.Log("Monedas recolectadas:" + _coinSummary);
        Destroy(gameObject);
    }


}
