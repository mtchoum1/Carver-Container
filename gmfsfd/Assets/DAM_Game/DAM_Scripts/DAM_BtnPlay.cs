using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DAM_BtnPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayGame(){
        SceneManager.LoadScene("DAM_GS");
    }
    public void GoHome(){
        SceneManager.LoadScene("Loading");
    }
}
