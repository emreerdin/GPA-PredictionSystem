using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject mainMenuUIPanel;
    public GameObject surveyQuestionPanelUI;
    public GameObject loadingVideo;
    public GameObject resultPanel;
    public static Controller controller;
    // Start is called before the first frame update
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    void Start()
    {
        controller = this;
        mainMenuUIPanel.SetActive(true);
        surveyQuestionPanelUI.SetActive(false);
        loadingVideo.SetActive(false);
        resultPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSurvey()
    {
        mainMenuUIPanel.SetActive(false);
        surveyQuestionPanelUI.SetActive(true);

    }
}
