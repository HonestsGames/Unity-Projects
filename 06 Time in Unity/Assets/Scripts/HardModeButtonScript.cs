using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardModeButtonScript : MonoBehaviour
{
    public void HardMode()
    {
        MainScript.StartNewGame(1, 120);
    }
}
