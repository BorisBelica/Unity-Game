using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GetScore : MonoBehaviour
{
    public Text scoreText;

    public Timer timer;
    public float score;

    private void Start()
    {
        score = 0;
    }

    private void setScore()
    {
        score = 0;
    }

    public void plusScore()
    {
        score += timer.getTimeRemaining();
        showScore();
    }

    public void minusScore()
    {
        score -= timer.getTimeRemaining();
        showScore();
    }

    public void showScore()
    {
        scoreText.GetComponent<Text>().text = score.ToString("F0");
    }


}