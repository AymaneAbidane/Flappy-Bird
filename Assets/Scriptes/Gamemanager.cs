using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    
    [SerializeField] GameObject gameOverCanvas;
    private void Start()
    {
        gameOverCanvas.SetActive(false);
    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ReplayAndPlay()
    {

        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

   public void Quit()
    {
        Application.Quit();
    }

 


}
