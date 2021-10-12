using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiplication : MonoBehaviour
{
    [SerializeField] private Text resultText;

    private int[,] mult = new int[11, 11];
    private string multStr = "";

    private int n = 0;
    private int m = 0;

    public void onMultiply()
    {
        for (n = 1; n < 11; ++n)
        {
            for (m = 1; m < 11; ++m)
            {
                mult[n, m] = n * m;
                //Debug.Log($"{n} x {m} = {mult[n, m]}");
                multStr += $"{n} x {m} = {mult[n, m]} \r | \r";
            }
        multStr += "\n *** \n";
        }
        resultText.text = multStr;
        multStr = "";
    }
}
