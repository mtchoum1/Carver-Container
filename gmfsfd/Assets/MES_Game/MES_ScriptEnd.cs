using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MES_ScriptEnd : MonoBehaviour
{
    // Start is called before the first frame update
    Scene scenes;
    void Start()
    {
        Scene scenes = SceneManager.GetActiveScene();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D hit) {
        Scene scenes = SceneManager.GetActiveScene();  
        if(hit.gameObject.name.Contains("Player")) {
            Debug.Log("End!");
            if(scenes.name == "MES_SceneStage1") {
                SceneManager.LoadScene("MES_SceneStage2");
            }
            if(scenes.name == "MES_SceneStage2") {
                SceneManager.LoadScene("MES_SceneStage3");
            }
            if(scenes.name == "MES_SceneStage3") {
                SceneManager.LoadScene("MES_Scene_GameOver");
            }
        }
    }
}
