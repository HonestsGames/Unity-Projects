using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStrike : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(-220, 0, 0, ForceMode.Impulse);
    }
}
