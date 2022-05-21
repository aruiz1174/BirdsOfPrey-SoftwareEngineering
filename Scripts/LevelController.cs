using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    Enemy[] thiefs;
    [SerializeField] string currentLevel;
    [SerializeField] string nextLevel;

    void OnEnable()
    {
        thiefs = FindObjectsOfType<Enemy>();
    }

    bool thiefsDestroyed()
    {
        foreach (var thief in thiefs)
        {
            if (thief.gameObject.activeSelf)
                return false;
        }
        return true;
    }

    void advanceLevel()
    {
        Debug.Log(currentLevel + " Completed! Next Level: " + nextLevel);
        SceneManager.LoadScene(nextLevel);
    }

    void Update()
    {
        if (thiefsDestroyed())
            advanceLevel();
    }
}
