﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatusManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            ChangeScene();
        }
    }
    void ChangeScene(){
        SceneManager.LoadScene("ADVENTURE");
    }
}
