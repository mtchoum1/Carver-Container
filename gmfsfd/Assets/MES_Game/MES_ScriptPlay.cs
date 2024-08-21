using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MES_ScriptPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnClick() {
        SceneManager.LoadScene("MES_SceneStage1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
