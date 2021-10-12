using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public Text firstPinStatus;
    private int firstPin = 0;
    public Text secondPinStatus;
    private int secondPin = 0;
    public Text thirdPinStatus;
    private int thirdPin = 0;

    private int gameDifficult = -1;

    private int playerTry = 30;

    [SerializeField] private GameObject firstScreen;
    [SerializeField] private GameObject secondScreen;
    private GameObject currentScreen;

    void Start()
    {
        firstScreen.SetActive(true);
        currentScreen = firstScreen;
    }

    // Update is called once per frame
    void Update()
    {
        if ( gameDifficult == -1)
        {
            return;
        }

        TimerScript.ActivateTimer(TimerScript.timeLimitOnDifficult);
        if (timer < 0)
        {
            onGameOver("Вы проиграли. Попробуйте еще раз!");
        }
        if (playerTry == 0)
        {
            onGameOver("Вы проиграли. Попробуйте еще раз!");
        }
        if ( (firstPin == 5) & (secondPin == 5) & (thirdPin == 5) )
        {
            onGameOver("Вы выиграли! Попробуйте еще раз!");
        }
    }

    public void ChangeState(GameObject state)
    {
        if (currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
    }

    private void onGeneratePinsValues()
    {
        firstPin = Random.Range(0, 10) + 1;
        secondPin = Random.Range(0, 10) + 1;
        thirdPin = Random.Range(0, 10) + 1;
        while (firstPin == 5)
        {
            firstPin = Random.Range(0, 10) + 1;
        }
        while (secondPin == 5)
        {
            secondPin = Random.Range(0, 10) + 1;
        }
        while (thirdPin == 5)
        {
            thirdPin = Random.Range(0, 10) + 1;
        }
        firstPinStatus.text = firstPin.ToString();
        secondPinStatus.text = secondPin.ToString();
        thirdPinStatus.text = thirdPin.ToString();
    }

     private void onUseTool(int firstPoint, int secondPoint, int thirdPoint)
    {
        firstPin += firstPoint;
        if (firstPin > 10)
        {
            firstPin = 10;
        }
        if (firstPin < 1)
        {
            firstPin = 1;
        }
        firstPinStatus.text = firstPin.ToString();

        secondPin += secondPoint;
        if (secondPin > 10)
        {
            secondPin = 10;
        }
        if (secondPin < 1)
        {
            secondPin = 1;
        }
        secondPinStatus.text = secondPin.ToString();

        thirdPin += thirdPoint;
        if (thirdPin > 10)
        {
            thirdPin = 10;
        }
        if (thirdPin < 1)
        {
            thirdPin = 1;
        }
        thirdPinStatus.text = thirdPin.ToString();

        if (gameDifficult == 1)
        {
            tryCounter.text = "Количество попыток: " + (--playerTry).ToString();
        }
    }


    public void onUsePicklock()
    {
        onUseTool(1, -1, 0);
    }

    public void onUseProbe()
    {
        onUseTool(-1, 2, -1);
    }

    public void onUseHammer()
    {
        onUseTool(-1, 1, 1);
    }

    public void StartNewGame(int difficult, int limit)
    {
        onGeneratePinsValues() ;
        TimerScript.passTimer = Time.time;
        gameDifficult = difficult;
        timeLimitOnDifficult = limit;
    }

    private void onGameOver(string finalText)
    {
        gameDifficult = -1;
        playerTry = 30;
        ChangeState(firstScreen);
        gameResult.text = finalText;
    }


}
