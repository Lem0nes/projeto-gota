using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMenu : MonoBehaviour
{
    public GameObject EndGameUI;

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Fase 1");
    }
}
