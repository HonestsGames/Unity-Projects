using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaidCycle : MonoBehaviour
{
    [SerializeField] private Text enemiesCountText;
    [SerializeField] private UnitsScript Knights;
    private Image Plug;
    private AudioSource Sound;

    public int raidsDifficulty;

    private int safeCycles;
    public int SafeCycles
    {
        set
        {
            safeCycles = value;
        }
        get
        {
            return safeCycles;
        }
    }

    private float raid—ycleTime;
    public float Raid—ycleTime
    {
        set
        {
            raid—ycleTime = value;
        }
    }

    private int enemiesCount;
    public int EnemiesCount
    {
        set
        {
            enemiesCount = value;
        }
        get
        {
            return enemiesCount;
        }
    }

    private int raidsCount;
    public int RaidsCount
    {
        set
        {
            raidsCount = value;
        }
        get
        {
            return raidsCount;
        }
    }

    private float currentTimeOn—ycle;
    public float CurrentTimeOn—ycle
    {
        set
        {
            currentTimeOn—ycle = value;
        }
    }

    void Start()
    {
        Plug = GetComponent<Image>();
        Sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (raidsCount < safeCycles)
        {
            enemiesCount = 0;
        }
        else
        {
            if (enemiesCount == 0)
            {
                enemiesCount = Random.Range(1, 6);
            }

        }

        enemiesCountText.text = enemiesCount.ToString();
        currentTimeOn—ycle += Time.deltaTime;

        if (currentTimeOn—ycle >= raid—ycleTime)
        {
            if (enemiesCount != 0)
            {
                Sound.Play();
            }
            Knights.Count -= enemiesCount;
            currentTimeOn—ycle = 0;
            enemiesCount = (int)Mathf.Round(++raidsCount / raidsDifficulty) * Random.Range(1, 6);
        }

        Plug.fillAmount = currentTimeOn—ycle / raid—ycleTime;
    }
}
