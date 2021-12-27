using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class QuizManager : MonoBehaviour
{
   public List<QuestionAndAnswer> QnA; // pridat s?
   public GameObject[] options;
   public int currentQuestionIndex;  //current Question

   public Text QuestionTxt;

   public Timer timer;

   private void Start() 
   {
       generateQuestion();
   }

   public void correct()
   {
       QnA.RemoveAt(currentQuestionIndex);
       generateQuestion();
       timer.resetTimeRemaining();
   }

    // fiil the button text to answers
   void SetAnswers()
   {
       for (int i = 0; i < options.Length; i++)
       {
           // default false correct index
           options[i].GetComponent<AnswerScript>().isCorrect = false;
           options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestionIndex].Answers[i]; 

            if (QnA[currentQuestionIndex].CorrectAnswer == i+1)
            {
                // correct index set true
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
       }
   }

   void generateQuestion()
   {
       currentQuestionIndex = Random.Range(0, QnA.Count);

       QuestionTxt.text = QnA[currentQuestionIndex].Question;
       SetAnswers();
   }
}
