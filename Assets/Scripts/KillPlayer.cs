using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{

    public GameObject GameOverMenu;

    public GameObject CanvasSeringa;

    [SerializeField] Transform spawnPoint;

    [System.Obsolete]
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        Time.timeScale = 0f;
        GameOverMenu.SetActive(true);
        CanvasSeringa.SetActive(false);
    }

}
