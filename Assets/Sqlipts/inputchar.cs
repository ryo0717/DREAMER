using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inputchar : MonoBehaviour
{
    public string str;
    public bool point;//true 付点可　false 付点不可
    public bool semipoint;//true 付点可　false 付点不可
    public GameObject Namebox;
    NameManager nameManager;
    // Start is called before the first frame update
    void Start()
    {
        nameManager = Namebox.GetComponent<NameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Input(){
        if(nameManager.namelength < 6){
            nameManager.playerName[nameManager.namelength] = str;
            nameManager.namelength += 1;
            nameManager.Dot = point;
            nameManager.Round = point;
        }
    }
    public void InputDot(){
        if(nameManager.namelength < 6){
            if(nameManager.Dot){
                nameManager.playerName[nameManager.namelength] = str;
                nameManager.namelength += 1;
                nameManager.Dot = point;
                nameManager.Round = point;
            }
        }
    }
    public void InputRount(){
        if(nameManager.namelength < 6){
            if(nameManager.Round){
                nameManager.playerName[nameManager.namelength] = str;
                nameManager.namelength += 1;
                nameManager.Dot = point;
                nameManager.Round = point;
            }
        }
    }
    public void InputStretcher(){
        if(nameManager.namelength < 6 && nameManager.namelength > 0){
            nameManager.playerName[nameManager.namelength] = str;
            nameManager.namelength += 1;
            nameManager.Dot = point;
            nameManager.Round = point;
        }
    }
    public void DeleteName(){
        if(nameManager.namelength > 0){
            nameManager.namelength -= 1;
            nameManager.playerName[nameManager.namelength] = "";   
        }
    }
    public void DecisionName(){
        if(nameManager.namelength > 0){
            SceneManager.LoadScene("SCENARIO");
        }
    }
}
