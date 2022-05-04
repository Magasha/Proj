using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play(int number)
    {
        SceneManager.LoadScene(number);
        AudioListener.volume = 0.45f;
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
