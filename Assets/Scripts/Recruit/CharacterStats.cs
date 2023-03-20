using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    
    public class Character
    {
        public string name;
        public int speed;       
            
        public Character(string rName, int rSpeed)
        {
            //stats for the character
            this.name = rName;
            this.speed = rSpeed;
        }
    }

    
    public List<Character> RecruitList = new();
    public string[] nameList;

    //Creates new character with random stats
    public void RecruitCharacters()
    {
        for (int i = 1; i <= 3; i++)
        {
            //creates random stats
            string x = nameList[Random.Range(0, nameList.Length)];
            int y = Random.Range(1, 10);

            var NewCharacter = new Character(x, y);
            
            
            RecruitList.Add(NewCharacter);
        }
    }
}

