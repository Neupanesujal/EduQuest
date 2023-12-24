using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizEnable : MonoBehaviour
{
  
    public static quizEnable instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this; 
        }
    }
    [SerializeField] private GameObject quiz;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.gameObject.CompareTag("quizDialogue")){
            quiz.SetActive(true);
        }
  }
  public void disableQuiz(){
    quiz.SetActive(false);
  }
}
