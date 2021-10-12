using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Factorial : MonoBehaviour
{
    [SerializeField] private InputField numb;
    [SerializeField] private Text resultText;

    private long p = 1;
    private int i = 0;
    private int n = 0;
    private string factStr = "";

    public void onFact()
    {
        if (int.TryParse(numb.text, out i))
        {
            if (i == 0)
            {
                resultText.text =  "0! = 1";
                //Debug.Log("0! = 1");
                return;
            }
            if (i < 0)
            {
                resultText.text =  $"{i}! = \u221E";
                //Debug.Log($"{i}! = \u221E");
                return;
            }
            while (n != i)
            {
                p *= ++n;
                //Debug.Log(p);
            }
            resultText.text = $"{i}! = {p.ToString()}";
        }
        else
        {
            resultText.text = "Введите целое число!";
        }
    }
}
