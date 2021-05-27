using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeringaCounterScript : MonoBehaviour
{
    Text coinText;
    public static int coinAmount;

    private void Start()
    {
        coinText = GetComponent<Text>();
        coinAmount = 0;
    }
    private void Update()
    {
        coinText.text = coinAmount.ToString();
    }
}
