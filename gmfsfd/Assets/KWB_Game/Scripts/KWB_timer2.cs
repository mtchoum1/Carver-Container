﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KWB_timer2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float KWB_time = 0f;
    public float KWB_seconds;
    public float count;
    public Text txt;
    private Rigidbody2D car;

    void Start()
    {
        car = GameObject.Find("car").GetComponent<Rigidbody2D>();
        count = 30 - KWB_staticTime.count;
        txt.text = "Time: " + count;
    }

    // Update is called once per frame
    void Update()
    {
        car.velocity = new Vector2 (10f, 0);

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
