using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KWB_timer3 : MonoBehaviour
{
    // Start is called before the first frame update
    public float KWB_time = 0f;
    public float KWB_seconds;
    public float count;
    public Text txt;

    void Start()
    {
        count = 30 - KWB_staticTime.count;
        txt.text = "Time: " + count;
    }

    // Update is called once per frame
    void Update()
    {
        KWB_time += Time.deltaTime;
        if (KWB_time >= 1)
        {
            KWB_seconds++;
            count--;
            txt.text = "Time: " + count;
            KWB_time = 0f;
        }


    }
}
