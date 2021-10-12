using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameScript : MonoBehaviour
{
    [SerializeField] private Slider startGold;
    [SerializeField] private Slider startTownGrade;
    [SerializeField] private Slider startArchangelCount;
    [SerializeField] private Slider startKnightCount;
    [SerializeField] private Slider recruiting—ycle;
    [SerializeField] private Slider mining—ycle;
    [SerializeField] private Slider raid—ycle;
    [SerializeField] private Slider safe—ycle;

    [SerializeField] private Slider goldToWin;
    [SerializeField] private Slider townGradeToWin;
    [SerializeField] private Slider archangelCountToWin;
    [SerializeField] private Slider knightCountToWin;
    [SerializeField] private Slider raidsArrived;

    [SerializeField] private GoldCycle goldStatus;
    [SerializeField] private RaidCycle raidStatus;
    [SerializeField] private UnitsScript Archangels;
    [SerializeField] private UnitsScript Knights;
    [SerializeField] private TownGradeScript TownGrade;
    [SerializeField] private RecruitingSctipt RecruitingOne;
    [SerializeField] private RecruitingSctipt RecruitingTwo;
    [SerializeField] private MainScript Purposes;


    public void StartNewGame()
    {
        Time.timeScale = 1;
        Purposes.OnPlay = true;
        goldStatus.Mining—ycleTime = mining—ycle.value;
        goldStatus.GoldCount = (int)startGold.value;
        raidStatus.Raid—ycleTime = raid—ycle.value;
        raidStatus.SafeCycles = (int)safe—ycle.value;
        Archangels.Count = (int)startArchangelCount.value;
        Archangels.TownGradeForUnitsCount = (int)startTownGrade.value;
        Knights.Count = (int)startKnightCount.value;
        Knights.TownGradeForUnitsCount = (int)startTownGrade.value;
        TownGrade.CurrentGarde = (int)startTownGrade.value;
        RecruitingOne.Recruiting—ycleTime = recruiting—ycle.value;
        RecruitingTwo.Recruiting—ycleTime = recruiting—ycle.value;
        TownGrade.Building—ycleTime = recruiting—ycle.value;
        Purposes.GoldToWin = (int)goldToWin.value;
        Purposes.TownGradeToWin = (int)townGradeToWin.value;
        Purposes.ArchangelCountToWin = (int)archangelCountToWin.value;
        Purposes.KnightCountToWin = (int)knightCountToWin.value;
        Purposes.RaidArrivesToWin = (int)raidsArrived.value;
    }
}
