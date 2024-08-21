using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JWA_Timer : MonoBehaviour
{
    public static float time = 25;
    public Text Timer;
    string timeHold;
    int finalTimeValue;
    // Start is called before the first frame update
    void Start()
    {
        //time = 25;
    }
    



    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            //time -= Time.deltaTime;
            int seconds = (int)time % 60;
            time -= Time.deltaTime;
            timeHold = seconds.ToString();
            Timer.text = timeHold;
        }
        else
        {
            SceneManager.LoadScene("Loading");
        }
    }
}
