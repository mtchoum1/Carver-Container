using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LDG_NextGame : MonoBehaviour
{
    void OnMouseDown()
    {
    SceneManager.LoadScene("Loading");
    LDG_Display2.score = 3; 
    LDG_Display.score = 0;
    }
}
