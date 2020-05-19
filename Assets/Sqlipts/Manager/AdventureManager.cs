using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdventureManager : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.S)){
            ChangeSceneStatus();
        }
    }
    void ChangeScene(){
        SceneManager.LoadScene("BATTLE");
    }
    void ChangeSceneStatus(){
        SceneManager.LoadScene("STATUS",LoadSceneMode.Additive);
    }
}
