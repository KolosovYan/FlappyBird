using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private int score;
    [SerializeField] private float defaultTimeScale;
    [SerializeField] private UI_Controller uI_Controller;

    private void Start()
    {
        Time.timeScale = defaultTimeScale;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        uI_Controller.ShowGameOverButtons();
        Debug.Log("You lose");
    }

    public void AddPoint()
    {
        score += 1;
        uI_Controller.UpdateScoreText(score.ToString());
    }

    public void RestartScene()
    {
        PlayerController.IsDead = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
