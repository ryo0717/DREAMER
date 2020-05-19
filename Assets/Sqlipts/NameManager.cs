using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour
{
    public string[] playerName = new string[6];

    public GameObject NameObj = null;
    public int namelength = 0;
    public bool Dot = false;
    public bool Round = false;

    // Update is called once per frame
    void Update()
    {
        Text Name = NameObj.GetComponent<Text>();
        Name.text = playerName[0]+playerName[1]+playerName[2]+playerName[3]+playerName[4]+playerName[5];
    }
    
}
