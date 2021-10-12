using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    [SerializeField] private Text purposesGoldText;
    [SerializeField] private Text purposesGradeText;
    [SerializeField] private Text purposesArchangelCountText;
    [SerializeField] private Text purposesKnightCountCountText;
    [SerializeField] private Text purposesDefenseRaid;
    [SerializeField] private Image gameoverBackground;
    [SerializeField] private Sprite winSprite;
    [SerializeField] private Sprite loseSprite;
    [SerializeField] private AudioSource winSound;
    [SerializeField] private AudioSource loseSound;

    [SerializeField] private GameObject GameScreen;
    [SerializeField] private GameObject EndGameScreen;

    [SerializeField] private Text titleText;
    [SerializeField] private Text resultGoldText;
    [SerializeField] private Text resultGradeText;
    [SerializeField] private Text resultRaidsText;

    [SerializeField] private GoldCycle Gold;
    [SerializeField] private TownGradeScript TownGrade;
    [SerializeField] private UnitsScript Archangels;
    [SerializeField] private UnitsScript Knights;
    [SerializeField] private RaidCycle Raids;
    [SerializeField] private RecruitingSctipt ArchangelRecruiting;
    [SerializeField] private RecruitingSctipt KnightRecruiting;

    private int goldToWin;
    public int GoldToWin
    {
        set
        {
            goldToWin = value;
        }
        get
        {
            return goldToWin;
        }
    }

    private int townGradeToWin;
    public int TownGradeToWin
    {
        set
        {
            townGradeToWin = value;
        }
        get
        {
            return townGradeToWin;
        }
    }

    private int archangelCountToWin;
    public int ArchangelCountToWin
    {
        set
        {
            archangelCountToWin = value;
        }
        get
        {
            return archangelCountToWin;
        }
    }

    private int knightCountToWin;
    public int KnightCountToWin
    {
        set
        {
            knightCountToWin = value;
        }
        get
        {
            return knightCountToWin;
        }
    }

    private int raidArrivesToWin;
    public int RaidArrivesToWin
    {
        set
        {
            raidArrivesToWin = value;
        }
        get
        {
            return raidArrivesToWin;
        }
    }

    private bool onPlay;
    public bool OnPlay
    {
        set
        {
            onPlay = value;
        }
        get
        {
            return onPlay;
        }
    }

    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {

        if (onPlay == false)
        {
            return;
        }

        if (Knights.Count < 0)
        {
            GameOver(false);
            return;
        }
        else
        {
            if ((Gold.GoldCount >= goldToWin) & (TownGrade.CurrentGarde >= townGradeToWin) & (Archangels.Count >= ArchangelCountToWin) & (Knights.Count >= KnightCountToWin) & ((Raids.RaidsCount - Raids.SafeCycles) >= raidArrivesToWin))
            {
                GameOver(true);
                return;
            }
        }
    }

    public void OnPause()
    {
        Time.timeScale = 0;
        purposesGoldText.text = Gold.GoldCount.ToString() + " / " + goldToWin.ToString();
        purposesGradeText.text = TownGrade.CurrentGarde.ToString() + " / " + townGradeToWin.ToString();
        purposesArchangelCountText.text = Archangels.Count.ToString() + " / " + ArchangelCountToWin.ToString();
        purposesKnightCountCountText.text = Knights.Count.ToString() + " / " + KnightCountToWin.ToString();
        purposesDefenseRaid.text = Mathf.Clamp((Raids.RaidsCount - Raids.SafeCycles), 0, Raids.RaidsCount).ToString() + " / " + raidArrivesToWin.ToString();
    }
    public void On—ontinue()
    {
        Time.timeScale = 1;
    }

    public void GameOver(bool win)
    {
        Time.timeScale = 0;
        GameScreen.SetActive(false);
        EndGameScreen.SetActive(true);

        if (win)
        {
            winSound.Play();
            gameoverBackground.sprite = winSprite;
            titleText.text = "¬˚ ÔÓ·Â‰ËÎË!";
            resultRaidsText.text = Mathf.Clamp((Raids.RaidsCount - Raids.SafeCycles), 0, Raids.RaidsCount).ToString();
        }
        else
        {
            loseSound.Play();
            gameoverBackground.sprite = loseSprite;
            titleText.text = "¬˚ ÔÓË„‡ÎË!";
            resultRaidsText.text = Mathf.Clamp((Raids.RaidsCount - Raids.SafeCycles - 1), 0 , Raids.RaidsCount).ToString();
        }

        resultGoldText.text = Gold.GoldCount.ToString();
        resultGradeText.text = TownGrade.CurrentGarde.ToString();

        Raids.RaidsCount = 0;
        ArchangelRecruiting.CurrentTimeOn—ycle = 0;
        ArchangelRecruiting.OnProcess = false;
        KnightRecruiting.CurrentTimeOn—ycle = 0;
        KnightRecruiting.OnProcess = false;
        TownGrade.CurrentTimeOn—ycle = 0;
        TownGrade.OnProcess = false;
        Gold.CurrentTimeOn—ycle = 0;
        Raids.CurrentTimeOn—ycle = 0;

        onPlay = false;
    }
}
