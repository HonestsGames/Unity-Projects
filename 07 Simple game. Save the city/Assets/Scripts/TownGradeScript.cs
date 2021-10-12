using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TownGradeScript : MonoBehaviour
{
    [SerializeField] private Text buttonText;
    [SerializeField] private Image buildingImage;
    [SerializeField] private Button buildingButton;
    [SerializeField] private GameObject buttonAsObject;
    [SerializeField] private Sprite[] townViewImage = new Sprite[4];
    [SerializeField] private UnitsScript archangelsMax;
    [SerializeField] private UnitsScript knightsMax;
    [SerializeField] private GoldCycle playersGolds;

    private Image Plug;
    private AudioSource Sound;

    public int[] townGardeCost = new int[4];
    public string buildingText;

    private int currentGarde;
    public int CurrentGarde
    {
        set
        {
            currentGarde = value;
        }
        get
        {
            return currentGarde;
        }
    }

    private float building—ycleTime;
    public float Building—ycleTime
    {
        set
        {
            building—ycleTime = value;
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
        Plug = GetComponent<Image>();
        Sound = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (onProcess)
        {
            buildingButton.interactable = false;
            currentTimeOn—ycle += Time.deltaTime;
            Plug.fillAmount = currentTimeOn—ycle / building—ycleTime;
            if (currentTimeOn—ycle >= building—ycleTime)
            {
                ++currentGarde;
                archangelsMax.TownGradeForUnitsCount = currentGarde;
                knightsMax.TownGradeForUnitsCount = currentGarde;
                currentTimeOn—ycle = 0;
                onProcess = false;
                Plug.fillAmount = 0;
            }
        }
        else
        {
            buttonText.text = buildingText + townGardeCost[currentGarde].ToString();
            buildingImage.sprite = townViewImage[currentGarde];

            if (currentGarde == ( townGardeCost.Length - 1))
            {
                buttonAsObject.SetActive(false);
                return;
            }

            if (playersGolds.GoldCount >= townGardeCost[currentGarde])
            {
                buildingButton.interactable = true;
            }
            else
            {
                buildingButton.interactable = false;
            }
            Plug.fillAmount = 0;
        }


    }

    public void OnBuilding()
    {
        onProcess = true;
        Sound.Play();
        playersGolds.GoldCount -= townGardeCost[currentGarde];
    }
}
