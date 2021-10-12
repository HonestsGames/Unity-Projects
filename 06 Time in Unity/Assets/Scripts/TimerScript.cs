using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public Text timerText;
    public Text gameResult;
    public Text tryCounter;

    public float timer = 0.00f;
    public float passTimer = 0.00f;
    public float timeLimitOnDifficult = 0.00f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateTimer(float timeLimit)
    {
        timer = timeLimit - (Time.time - passTimer);
        timerText.text = "Таймер: " + Mathf.Round(timer).ToString();
    }
}
