using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
   
    void Start()
    {
    }

    
    void Update()
    {
        
    }

   public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego");
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
