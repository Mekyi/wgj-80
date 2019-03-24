using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] GameObject credits;
    [SerializeField] GameObject directionalLight;
    [SerializeField] GameObject virtualCam;
    [SerializeField] GameObject victoryText;
    [SerializeField] GameObject gameOverMenu;
    [SerializeField] Light playerlight;

    bool gameOver = false;

    private void Update()
    {
        if (gameOver)
        {
            playerlight.range -= 2 * Time.deltaTime;
        }
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void FinishGame()
    {
        credits.SetActive(true);
        directionalLight.SetActive(true);
        FindObjectOfType<UI>().GameCompleted();
        victoryText.SetActive(true);
    }

    public void GameOver()
    {
        gameOver = true;
        StartCoroutine(GameOverSequency());
    }

    IEnumerator GameOverSequency()
    {
        yield return new WaitForSeconds(5f);
        gameOverMenu.SetActive(true);
    }
}
