using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;

    

    public void Answer()
    {
        Debug.Log("Answer");
        if(isCorrect)
        {
            Debug.Log("Correct");
            quizManager.instance.correct();
        }
        else
        {
            Debug.Log("wrong");
            quizManager.instance.correct();
        }
    }
}