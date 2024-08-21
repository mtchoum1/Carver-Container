using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KWB_endgame : MonoBehaviour
{
    private float KWB_seconds;
    private float KWB_time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KWB_time += Time.deltaTime;
        if (KWB_time >= 1)
        {
            KWB_seconds++;

            KWB_time = 0f;
        }

        if (KWB_seconds == 8)
        {
            SceneManager.LoadScene("Loading");

        }
    }
}
