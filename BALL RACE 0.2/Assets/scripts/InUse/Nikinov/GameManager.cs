using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    GameObject CompleteLevel;

    GameObject pauseLevel;

    GameObject DethPanel;

    GameObject GamePanel;

    public GameObject BlackPanelUI;

    public GameObject Speedo;

    private void Start()
    {
        DethPanel = GameObject.FindGameObjectWithTag("DethPanel");
        CompleteLevel = GameObject.FindGameObjectWithTag("CompleteLevel");
        pauseLevel = GameObject.FindGameObjectWithTag("PauseMenu");
        GamePanel = GameObject.FindGameObjectWithTag("GamePanel");
        DethPanel.SetActive(false);
        CompleteLevel.SetActive(false);
        pauseLevel.SetActive(false);
        GamePanel.SetActive(true);
        Speedo.SetActive(true);
        StartCoroutine(SetBlackFalse());
    }

    public void completeLevel()
    {
        CompleteLevel.SetActive(true);
        GamePanel.SetActive(false);
    }
    public void PauseLevel()
    {
        pauseLevel.SetActive(true);
        GamePanel.SetActive(false);
        Time.timeScale = 0f;
        Speedo.SetActive(false);
    }
    public void ResumeLevel()
    {
        pauseLevel.SetActive(false);
        GamePanel.SetActive(true);
        Time.timeScale = 1f;
        Speedo.SetActive(true);
    }

    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("game over");
            Deth();
            GamePanel.SetActive(false);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Deth()
    {
        DethPanel.SetActive(true);
        BlackPanelUI.SetActive(false);
    }
    public void ToMap()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
    public void ToStore()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
        Time.timeScale = 1f;
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
        Time.timeScale = 1f;
    }
    IEnumerator SetBlackFalse()
    {
        BlackPanelUI.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        BlackPanelUI.SetActive(false);
    }
}