using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperCubeStriker : MonoBehaviour
{
    [SerializeField] private float strikeForce;
    [SerializeField] private float moveToX;
    [SerializeField] private float moveToY;
    [SerializeField] private float moveToZ;

    private Transform transform;
    private Rigidbody rigidbody;

    void Start()
    {
        transform = GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 movementVector = new Vector3(moveToX, moveToY, moveToZ);
        rigidbody.velocity = movementVector;
    }

    private void OnCollisionEnter(Collision target)
    {
        Vector3 strikeVector = (target.gameObject.transform.position - transform.position) * strikeForce;
        target.gameObject.GetComponent<Rigidbody>().AddForce(strikeVector, ForceMode.Impulse);
    }

}
