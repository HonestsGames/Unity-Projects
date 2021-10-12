using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    [SerializeField] private GameObject firstScreen;
    [SerializeField] private GameObject secondScreen;
    [SerializeField] private InputField answField_1;
    [SerializeField] private InputField answField_2;
    [SerializeField] private InputField answField_3;
    [SerializeField] private InputField answField_4;
    [SerializeField] private InputField answField_5;
    [SerializeField] private InputField answField_6;
    [SerializeField] private InputField answField_7;
    [SerializeField] private InputField answField_8;
    [SerializeField] private InputField answField_9;
    [SerializeField] private InputField answField_10;
    [SerializeField] private Text ResultText;
    private GameObject currentScreen;
    int Q_nunber = 0;
    int Right = 0;
    int Fall = 0;

    void Start()
    {
        firstScreen.SetActive(true);
        currentScreen = firstScreen;
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

    public void Answer()
    {
        ++Q_nunber;
        switch (Q_nunber)
        {
            case 1:
                if (answField_1.text == "Берлин")
                {
                    ++Right;

                    break;
                }
                else
                {
                    ++Fall;
                    break;
                }
            case 2:
                if ((answField_2.text == "Джоуль") ^ (answField_2.text == "Джоули") ^ (answField_2.text == "Дж"))
                {
                    ++Right;
                    break;
                }
                else
                {
                    ++Fall;
                    break;
                }
            case 3:
                if (answField_3.text == "Серебро")
                {
                    ++Right;
                    break;
                }
                else
                {
                    ++Fall;
                    break;
                }
            case 4:
                if (answField_4.text == "Амазонка")
                {
                    ++Right;
                    break;
                }
                else
                {
                    ++Fall;
                    break;
                }
            case 5:
                if (answField_5.text == "Хлорофилл")
                {
                    ++Right;
                    break;
                }
                else
                {
                    ++Fall;
                    break;
                }
            case 6:
                if ((answField_6.text == "Колибри") ^ (answField_6.text == "Колибри-пчёлка") ^ (answField_6.text == "Колибри-пчелка"))
                {
                    ++Right;
                    break;
                }
                else
                {
                    ++Fall;
                    break;
                }
            case 7:
                if ((answField_7.text == "3") ^ (answField_7.text == "Третьей") ^ (answField_7.text == "Третей"))
                {
                    ++Right;
                    break;
                }
                else
                {
                    ++Fall;
                    break;
                }
            case 8:
                if ((answField_8.text == "Скорости") ^ (answField_8.text == "Скорость"))
                {
                    ++Right;
                    break;
                }
                else
                {
                    ++Fall;
                    break;
                }
            case 9:
                if ((answField_9.text == "46") ^ (answField_9.text == "Сорок шесть"))
                {
                    ++Right;
                    break;
                }
                else
                {
                    ++Fall;
                    break;
                }
            case 10:
                if ((answField_10.text == "3") ^ (answField_10.text == "Три"))
                {
                    ++Right;
                    break;
                }
                else
                {
                    ++Fall;
                    break;
                }
            default:
                break;
        }
    }

    public void ShowRes()
    {
        ResultText.text = $"Правильных ответов: {Right.ToString()} \nНеправильных ответов: {Fall.ToString()}";
        answField_1.text = "";
        answField_2.text = "";
        answField_3.text = "";
        answField_4.text = "";
        answField_5.text = "";
        answField_6.text = "";
        answField_7.text = "";
        answField_8.text = "";
        answField_9.text = "";
        answField_10.text = "";
        Q_nunber = 0;
        Right = 0;
        Fall = 0;
    }

}


