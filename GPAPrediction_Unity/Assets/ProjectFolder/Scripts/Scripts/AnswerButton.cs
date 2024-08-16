using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AnswerButton : MonoBehaviour
{
    public int answerValue;
    private Slider parentSlider;
    private Text sliderText;
    // Start is called before the first frame update
    void Start()
    {
        if (transform.parent.GetComponent<Slider>())
        {
            parentSlider = transform.parent.GetComponent<Slider>();
            sliderText = GameObject.FindGameObjectWithTag("SliderValue").GetComponent<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetAnswer1()
    {
        Answer.answers.answer1 = answerValue;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(false);
        Answer.answers.questionIndex++;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(true);
    }
    public void SetAnswer2()
    {
        Answer.answers.answer2 = answerValue;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(false);
        Answer.answers.questionIndex++;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(true);
    }
    public void SetAnswer3()
    {
        Answer.answers.answer3 = answerValue;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(false);
        Answer.answers.questionIndex++;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(true);
    }
    public void SetAnswer4()
    {
        Answer.answers.answer4 = answerValue;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(false);
        Answer.answers.questionIndex++;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(true);
    }
    public void SetAnswer5()
    {
        Answer.answers.answer5 = answerValue;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(false);
        Answer.answers.questionIndex++;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(true);
    }
    public void SetAnswer6()
    {
        Answer.answers.answer6 = int.Parse(parentSlider.value.ToString());
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(false);
        Answer.answers.questionIndex++;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(true);
    }
    public void SetAnswer7()
    {
        Answer.answers.answer7 = answerValue;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(false);
        Answer.answers.questionIndex++;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(true);
    }
    public void SetAnswer8()
    {
        Answer.answers.answer8 = answerValue;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(false);
        Answer.answers.questionIndex++;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(true);
    }
    public void SetAnswer9()
    {
        Answer.answers.answer9 = answerValue;
        Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(false);
        Answer.answers.questionIndex++;
        if (!(Answer.answers.questions.Count <= Answer.answers.questionIndex)) {
            Answer.answers.questions[Answer.answers.questionIndex].gameObject.SetActive(true);
        }
        else
        {
            Answer.answers.end = true;
            Controller.controller.surveyQuestionPanelUI.SetActive(false);
            Controller.controller.loadingVideo.SetActive(true);
        }
        
    }

    public void SetSliderText()
    {
        sliderText.text = parentSlider.value.ToString();
    }
}
