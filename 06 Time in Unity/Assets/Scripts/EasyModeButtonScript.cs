using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyModeButtonScript : MonoBehaviour
{
    public void EasyMode()
    {
        MainScript.StartNewGame(0, 180);
    }
}
