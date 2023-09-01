using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountJumps : MonoBehaviour
{
    public Text countText;
    int jumpCt = 0;

    void OnEnable()
    {
        Countdown.TimesUp += Jump; // register for jump event
    }

    void OnDisable()
    {
        Countdown.TimesUp -= Jump; // deregister for jump event
    }

    // called from Countdown (when TimesUp is called)
    void Jump()
    {
        jumpCt++;
        countText.text = jumpCt.ToString();
    }
}
