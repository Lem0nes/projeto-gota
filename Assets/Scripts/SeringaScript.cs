using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeringaScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            StxManager.sfxInstance.Audio.PlayOneShot(StxManager.sfxInstance.Seringa);
            SeringaCounterScript.coinAmount += 1;
            Destroy(gameObject);
        }
    }
}
