using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecruitingSctipt : MonoBehaviour
{
    [SerializeField] private RecruitingSctipt otherRecruiting;
    [SerializeField] private Text buttonText;
    [SerializeField] private Button recruitingButton;
    [SerializeField] private Image recruitingStatus;
    [SerializeField] private UnitsScript Unit;
    [SerializeField] private GoldCycle playersGolds;

    public int unitsCost;
    public string recruitingText;

    private AudioSource Sound;

    private bool maxCount = false;
    public bool MaxCount
    {
        set
        {
            maxCount = value;
        }

    }

    private float recruiting—ycleTime;
    public float Recruiting—ycleTime
    {
        set
        {
            recruiting—ycleTime = value;
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

    private bool onProcess;
    public bool OnProcess
    {
        set
        {
            onProcess = value;
        }
    }

    void Start()
    {
        buttonText.text = recruitingText + unitsCost.ToString();
        Sound = GetComponent<AudioSource>();
    }

    public void OnRecruiting()
    {
        onProcess = true;
        playersGolds.GoldCount -= unitsCost;
    }

    void Update()
    {
        if (maxCount)
        {
            recruitingButton.interactable = false;
            return;
        }

        if (onProcess)
        {
            recruitingButton.interactable = false;
            currentTimeOn—ycle += Time.deltaTime;
            recruitingStatus.fillAmount = currentTimeOn—ycle / recruiting—ycleTime;
            if (currentTimeOn—ycle >= recruiting—ycleTime)
            {
                Sound.Play();
                ++Unit.Count;
                currentTimeOn—ycle = 0;
                onProcess = false;
                recruitingStatus.fillAmount = 0;            
            }
        }
        else
        {
            if ((playersGolds.GoldCount >= unitsCost) & (otherRecruiting.onProcess == false))
            {
                recruitingButton.interactable = true;
            }
            else
            {
                recruitingButton.interactable = false;
            }
            recruitingStatus.fillAmount = 0;
        }
    }
}
