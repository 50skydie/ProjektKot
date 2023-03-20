using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecruitOnClick : MonoBehaviour
{
    public GameObject RecruitWindow;
    public AgentHandler AH;
    public CharacterStats CH;
    
   public void OnClickRecruitCh1()
    {
        //copy chosen character to agents and delete every character
        RecruitWindow.SetActive(false);
        GetComponent<CharacterStats>().RecruitList.Clear();
    }
    public void OnClickRecruitCh2()
    {
        //copy chosen character to agents and delete every character
        RecruitWindow.SetActive(false);
        GetComponent<CharacterStats>().RecruitList.Clear();
    }
    public void OnClickRecruitCh3()
    {
        //copy chosen character to agents and delete every character 
        RecruitWindow.SetActive(false);
        GetComponent<CharacterStats>().RecruitList.Clear();
    }

}
