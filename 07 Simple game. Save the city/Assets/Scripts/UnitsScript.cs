using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitsScript : MonoBehaviour
{
    [SerializeField] private Text unitsBar;
    [SerializeField] private RecruitingSctipt setMaxBool;

    public int[] CountMax = new int[4];

    private int count;
    public int Count
    {
        set
        {
            count = value;
        }
        get
        {
            return count;
        }
    }

    private int townGradeForUnitsCount;
    public int TownGradeForUnitsCount
    {
        set
        {
            townGradeForUnitsCount = value;
        }
        get
        {
            return townGradeForUnitsCount;
        }
    }

    void Update()
    {
        if (Count == CountMax[TownGradeForUnitsCount])
        {
            setMaxBool.MaxCount = true;
        }
        else
        {
            setMaxBool.MaxCount = false;
        }

        Count = Mathf.Clamp(Count, -1, CountMax[TownGradeForUnitsCount]);
        unitsBar.text = Count.ToString() + "/" + CountMax[TownGradeForUnitsCount].ToString();
    }
}
