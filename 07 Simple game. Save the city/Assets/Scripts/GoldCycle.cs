using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCycle : MonoBehaviour
{
    [SerializeField] private Text goldPerCycleText;
    [SerializeField] private Text goldCountText;
    [SerializeField] private UnitsScript Archangel;
    private Image Plug;
    private AudioSource Sound;

    public int goldMiningFactor;

    private int goldPerCycle;
    private float mining—ycleTime;
    public float Mining—ycleTime
    {
        set
        {
            mining—ycleTime = value;
        }
    }

    private int goldCount;
    public int GoldCount
    {
        set
        {
            goldCount = value;
        }
        get
        {
            return goldCount;
        }
    }

    private float currentTimeOn—ycle;
    public int CurrentTimeOn—ycle
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

        goldPerCycle = goldMiningFactor * Archangel.Count;
        goldPerCycleText.text = goldPerCycle.ToString();
        currentTimeOn—ycle += Time.deltaTime;

        if (currentTimeOn—ycle >= mining—ycleTime)
        {
            Sound.Play();
            currentTimeOn—ycle = 0;
            goldCount = Mathf.Clamp((goldCount + goldPerCycle), 0, 9999);
        }

        goldCountText.text = goldCount.ToString();
        Plug.fillAmount = currentTimeOn—ycle / mining—ycleTime;
    }
}
