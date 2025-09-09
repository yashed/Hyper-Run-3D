using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public GameObject LevelPanel;


    
    public void Levels()
    {
        LevelPanel.SetActive(true);
    }

    public void LevelsToMainMenu()
    {
        LevelPanel.SetActive(false);

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Exit()

    {
        Application.Quit();
    }
}
