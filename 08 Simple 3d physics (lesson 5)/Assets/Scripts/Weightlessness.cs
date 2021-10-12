using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weightlessness : MonoBehaviour
{
    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ZeroGravityArea")
        {
            rigidbody.useGravity = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ZeroGravityArea")
        {
            rigidbody.useGravity = true;
        }
    }
}
