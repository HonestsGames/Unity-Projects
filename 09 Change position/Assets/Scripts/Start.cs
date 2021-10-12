using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    [SerializeField] private RelayRunner firstRunner;

    public void OnStart()
    {
        firstRunner.Run = true;
    }
}
