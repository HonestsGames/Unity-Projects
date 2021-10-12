using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvenNumb : MonoBehaviour
{
    [SerializeField] private Text resultText;

    private string numbStr = "";

    private int n = 0;

    public void onFindNumb()
    {
        for (n = 2; n < 10; n+= 2)
        {
            //Debug.Log(n);
            numbStr += n.ToString() + " ";
        }
        resultText.text = numbStr;
        numbStr = "";
    }
}