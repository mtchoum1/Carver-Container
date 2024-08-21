using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DAM_Timer : MonoBehaviour{
    [SerializeField] Text txt;
    public static bool isCounting;
    private float countingDown;
    private int seconds;
    void Start()
    {
        seconds = 30;
        countingDown = 1;
    }
    void Update(){
        countingDown -= Time.deltaTime;
        if(countingDown <= 0){
            countingDown = 1;
            seconds -= 1;
        }
        txt.text = "Time: " + seconds;
        if(seconds == 0){
            SceneManager.LoadScene("DAM_ES");
        }
    }
}
