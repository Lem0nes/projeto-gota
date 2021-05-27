using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    private float Coin = 0;

    public AudioClip coinSound;

    public TextMeshProUGUI textCoins;

    public TextMeshProUGUI textCoins2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Coin")
        {
            Coin ++;
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            textCoins.text = Coin.ToString();
            textCoins2.text = Coin.ToString();
            Destroy(other.gameObject);       
        }
    }
}
