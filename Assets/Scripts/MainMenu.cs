using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("Fase 1");
        StxManager.sfxInstance.Audio.PlayOneShot(StxManager.sfxInstance.Click);
    }

    public void SelectMaps ()
    {
        SceneManager.LoadScene("SubMenu");
        StxManager.sfxInstance.Audio.PlayOneShot(StxManager.sfxInstance.Click);
    }

    public void BacktoMenu ()
    {
        SceneManager.LoadScene("Menu");
        StxManager.sfxInstance.Audio.PlayOneShot(StxManager.sfxInstance.Click);
    }

    public void Map01()
    {
        SceneManager.LoadScene("Fase 1");
        StxManager.sfxInstance.Audio.PlayOneShot(StxManager.sfxInstance.Click);
    }

    public void Map02()
    {
        SceneManager.LoadScene("Fase 2");
        StxManager.sfxInstance.Audio.PlayOneShot(StxManager.sfxInstance.Click);
    }

    public void Map03()
    {
        SceneManager.LoadScene("Fase 3");
        StxManager.sfxInstance.Audio.PlayOneShot(StxManager.sfxInstance.Click);
    }

    public void Map04()
    {
        SceneManager.LoadScene("Fase 4");
        StxManager.sfxInstance.Audio.PlayOneShot(StxManager.sfxInstance.Click);
    }
    public void Map05()
    {
        SceneManager.LoadScene("EndGame");
        StxManager.sfxInstance.Audio.PlayOneShot(StxManager.sfxInstance.Click);
    }

    public void QuitGame ()
    {
        Application.Quit();
        StxManager.sfxInstance.Audio.PlayOneShot(StxManager.sfxInstance.Click);
    }
}
