using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] private float zone;
    [SerializeField] private float timeToJump;
    [SerializeField] private float jumpForce;
    [SerializeField] private LayerMask layer;

    private float currentTime;

    private void Start()
    {
        currentTime = timeToJump;
    }

    private void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, zone, layer);

        if (colliders.Length != 0)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                foreach (Collider collider in colliders)
                {
                    collider.gameObject.GetComponent<Rigidbody>().AddForce(0, jumpForce, 0, ForceMode.Impulse);
                }
                currentTime = timeToJump;
            }
        }
    }
}
