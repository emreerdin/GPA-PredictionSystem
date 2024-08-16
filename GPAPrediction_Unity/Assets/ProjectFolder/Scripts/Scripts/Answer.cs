using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public int answer1;
    public int answer2;
    public int answer3;
    public int answer4;
    public int answer5;
    public int answer6;
    public int answer7;
    public int answer8;
    public int answer9;
    public static Answer answers;


    public List<GameObject> questions;
    public int questionIndex;

    public bool end;
    // Start is called before the first frame update
    void Start()
    {
        answers = this;

        questionIndex = 0;
        for (int i = 0; i < questions.Count; i++)
        {
            questions[i].gameObject.SetActive(false);
        }
        questions[questionIndex].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
