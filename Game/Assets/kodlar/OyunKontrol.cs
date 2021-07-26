using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    bool gamePause = true;
    public AudioMixer mixer;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Scenes/Menu");

        }
    }
    public void quitButton()
    {
        Debug.Log("QUİT");
        Application.Quit();
    }

    public void pauseButton()
    {
        if (gamePause)
        {
            Time.timeScale = 0;
            gamePause = false;
        }
        else
        {
            Time.timeScale = 1;
            gamePause = true;
        }
    }
    public void homeButton()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }
    public void resumeButton()
    {
        Time.timeScale = 1;
    }

    public void setVolume(float volume)
    {
        mixer.SetFloat("volume", Mathf.Log10 (volume) * 20);
    }
}
