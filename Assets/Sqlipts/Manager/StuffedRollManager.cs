using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StuffedRollManager : MonoBehaviour
{
    float move = 0.0f;
    float limit = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move += Time.deltaTime;
        if(move >= limit){
            ChangeScene();
        }
    }
    void ChangeScene(){
        SceneManager.LoadScene("TITLE");
    }
}
