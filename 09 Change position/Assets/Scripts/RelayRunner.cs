using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelayRunner : MonoBehaviour
{

    public float passDistance;

    [SerializeField] private Transform nextRunner;
    [SerializeField] private RelayRunner nextOnRunning;
    private Transform currentRunner;
    private bool run;
    public bool Run
    {
        set
        { run = value; }
    }

    void Start()
    {
        currentRunner = GetComponent<Transform>();
    }

    void Update()
    {
        if (run)
        {
            if (Vector3.Distance(currentRunner.position, nextRunner.position) > passDistance)
            {
                currentRunner.LookAt(nextRunner.position);
                currentRunner.position = Vector3.MoveTowards(currentRunner.position, nextRunner.position, Time.deltaTime);
            }
            else
            {
                run = false;
                nextOnRunning.Run = true;
            }
        }
    }
}
