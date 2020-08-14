using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorCon : MonoBehaviour
{
   public void StartLevel(int level)
    {
        string levelName = "Level" + level.ToString();
        SceneManager.LoadScene(levelName);
    }

    public void ExitGame()
    {
        Application.Quit();

    }
}
