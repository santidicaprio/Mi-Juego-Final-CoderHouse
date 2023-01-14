using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject panelTwo;
    [SerializeField] GameObject respawnPosition;
    void Start()
    {

    }

    
    void Update()
    {
        EscapeMenu();
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
    public void EscapeMenu()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            panelTwo.SetActive(true);

        }       
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        panelTwo.SetActive(false);
    }
}
