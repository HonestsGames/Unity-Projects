using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float explosionForce;
    [SerializeField] private float timeToExplosion;
    [SerializeField] private float radius;

    private AudioSource boomSound;

    private void Start()
    {
        boomSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        timeToExplosion -= Time.deltaTime;

        if (timeToExplosion <= 0)
        {
            Boom();
            timeToExplosion = 10;
        }
    }

    private void Boom()
    {
        
        Rigidbody[] blocks = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody block in blocks)
        {
            float calculate = Vector3.Distance(transform.position, block.transform.position);
            if (calculate < radius)
            {
                Vector3 direction = block.transform.position - transform.position;
                block.AddForce(direction.normalized * explosionForce * (radius - calculate), ForceMode.Impulse);
                boomSound.Play();
            }
        }
    }

}
