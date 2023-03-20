using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class DisplayCharStats : MonoBehaviour
{
    public CharacterStats CS;
    public TextMeshProUGUI StatText;
    public GameObject StatWindow;

    //Stats to display
    private string NameText;
    private int SpeedText;
    
    //Sets stats of chosen character
    public void SetStatsChar1()
    {
        NameText = GetComponent<CharacterStats>().RecruitList[0].name;
        SpeedText = GetComponent<CharacterStats>().RecruitList[0].speed;
    }
    public void SetStatsChar2()
    {
        NameText = GetComponent<CharacterStats>().RecruitList[1].name;
        SpeedText = GetComponent<CharacterStats>().RecruitList[1].speed;
    }
    public void SetStatsChar3()
    {
        NameText = GetComponent<CharacterStats>().RecruitList[2].name;
        SpeedText = GetComponent<CharacterStats>().RecruitList[2].speed;
    }
    
    public void OnEnter()
    {
        StatWindow.SetActive(true);
    }
    public void OnExit()
    {
        StatWindow.SetActive(false);
    }
    
    
    
    void Start()
    {
        StatWindow.SetActive(false);
    }
    public void Update()
    {
        //text that is displayed
        StatText.text = "Statystyki\tImiê: "+ NameText +"\tPrêdkoœæ: " + SpeedText + "\tOtherStats...";
    }



}
