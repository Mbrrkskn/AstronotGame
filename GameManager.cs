using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject WinPanel;
    public GameObject LosePanel;

    private void Awake()
    {
        instance = this;
        WinPanel.SetActive(false);
        LosePanel.SetActive(false);
    }

    public void WinGame()
    {
        WinPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoseGame()
    {
        LosePanel.SetActive(true);
        Time.timeScale = 0f;
    }

   
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
    public void QuitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
