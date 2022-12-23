using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject respawnPosition;
    void Start()
    {

    }

    
    void Update()
    {
    }
    public void SlowTime()
    {
        Debug.Log("Toque el finishgame");
        panel.SetActive(true);
        Time.timeScale = 0.03f;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        panel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        panel.SetActive(false);
        Time.timeScale = 1f;
    }
}
