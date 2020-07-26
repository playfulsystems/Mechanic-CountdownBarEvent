using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    // event
    public static event Action<int> TimesUp;

    public float countdownEverySeconds = 1f;
    public float counter;

    void Start()
    {
        // init the counter
        counter = countdownEverySeconds;
    }

    void Update()
    {
        // if countdown is up
        if (counter < 0)
		{
            TimesUp(0); // call the delegate
            counter = countdownEverySeconds;
        }

        // update width
        float percentDone = counter/countdownEverySeconds;
        transform.localScale = new Vector2(percentDone, 1f);

        // update counter 
        counter -= Time.deltaTime;
    }
}
