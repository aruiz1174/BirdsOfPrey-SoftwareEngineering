using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] string firstLevel;

    public void startGame()
    {
        SceneManager.LoadScene(firstLevel);
    }

    public void loadLevel()
    {
        SceneManager.LoadScene("LoadLevel");
    }

    public void closeGame()
    {
        Application.Quit();
        Debug.Log("You closed the game");
    }

    public void htp()
    {
        SceneManager.LoadScene("HTP");
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
