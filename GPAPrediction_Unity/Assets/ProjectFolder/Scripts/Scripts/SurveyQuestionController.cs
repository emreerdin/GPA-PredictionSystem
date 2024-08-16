using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurveyQuestionController : MonoBehaviour
{
    public Animator selfAnimator;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StopAnimator());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator StopAnimator()
    {
        yield return new WaitForSeconds(1);
        selfAnimator.enabled = false;
        StopAllCoroutines();
    }
}
