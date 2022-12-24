using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{
    [SerializeField] TMP_Text counterText;
    [SerializeField] float seconds, minutes;
    [SerializeField] float count = 0f;
    [SerializeField] string finalTime;
    
    
    
    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {

        finalTime = ("Your time was:"  + minutes  +  seconds);
        minutes = (int)(Time.time / 60f);
        seconds = (int)(Time.time % 60f);
        counterText.text = minutes.ToString("Time - 00") + ":" + seconds.ToString("00");

        
        
    }
    

}

