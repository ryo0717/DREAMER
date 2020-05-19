using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            ChangeScene();
        }
        if(Input.GetKey(KeyCode.S)){
            ChangeSceneScenario();
        }
    }
    void ChangeScene(){
        SceneManager.LoadScene("ADVENTURE");
    }
    void ChangeSceneScenario(){
        SceneManager.LoadScene("SCENARIO");
    }
}
