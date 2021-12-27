using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public GetScore getScore;
    public Timer timer;


    public void Answer()
    {
        if(isCorrect)
        {
            getScore.plusScore();
            getScore.showScore();
            
            Debug.Log("Correct Answer");
            quizManager.correct();
            timer.resetTimeRemaining();

         }

        else 
        {
            getScore.minusScore();
            getScore.showScore();
            Debug.Log("Wrong Answer");
            quizManager.correct();
        }
    }
}
