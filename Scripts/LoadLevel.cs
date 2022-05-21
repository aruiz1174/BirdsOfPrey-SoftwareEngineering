using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void load1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void load2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void load3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void load4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void load5()
    {
        SceneManager.LoadScene("Level5");
    }

    public void returnMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
