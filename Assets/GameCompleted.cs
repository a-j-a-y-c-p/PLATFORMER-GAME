using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCompleted : MonoBehaviour
{
    public PauseMenu menu;

    public void GameComplete()
    {        
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
