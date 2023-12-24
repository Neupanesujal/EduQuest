using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class quizManager : MonoBehaviour
{
    public List<QuestionandAnswer> QnA;
    public GameObject[] options;
    public int currentQuestions;
    public Text QuestionTxt;

    public static quizManager instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this; 
        }
    }

    private void Start()
    {
        generateQuestion();
    }

    public void correct()
    {
        QnA.RemoveAt(currentQuestions);
        generateQuestion();
    }
    public void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestions].Answers[i];

            if(QnA[currentQuestions].correctAnswers <= i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
            if(i == options.Length)
            {
                quizEnable.instance.disableQuiz();
            }
        }
    }
    void generateQuestion()
    {
       currentQuestions = Random.Range(0 , QnA.Count);
       QuestionTxt.text = QnA[currentQuestions].Question;
       SetAnswers();
    }
}
