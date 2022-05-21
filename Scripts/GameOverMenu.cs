using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] string firstLevel;
    [SerializeField] string mainMenu;

    public void replayGame()
    {
        SceneManager.LoadScene(firstLevel);
    }

    public void returnMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
