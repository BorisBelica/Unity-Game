using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 30; // default time
    public bool timerIsRunning = false;

    public Text timeRemainingText;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    public void resetTimeRemaining()
    {
        timeRemaining = 30;
    }

    public float getTimeRemaining()
    {
        return timeRemaining;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timeRemainingText.GetComponent<Text>().text = timeRemaining.ToString("F0");
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
}