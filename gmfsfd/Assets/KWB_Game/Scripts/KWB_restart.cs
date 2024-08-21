using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KWB_restart : MonoBehaviour
{

    public void Restart() 
    {
        SceneManager.LoadScene("KWB_Scene1");
        KWB_staticTime.count = 0;
    }

    public void Exit()
    {
        SceneManager.LoadScene("Loading");
    }
}
