using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public void HandlePlayButtonClickEvent()
    {
        PlayerPrefs.DeleteAll();
        Destroy(gameObject);
        Time.timeScale = 1;
        AudioListener.volume = 0.3f;
        SceneManager.LoadScene("GamePlay");
    }

    public void HandleAudioButtonClickEvent()
    {
        PlayerPrefs.SetInt("audioback", 1);
        PlayerPrefs.SetInt("audioOn", 1);

        Destroy(gameObject);
        MenuManager.GoToMenu(MenuName.Volume);
    }

    public void HandleQuitButtonClickEvent()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
