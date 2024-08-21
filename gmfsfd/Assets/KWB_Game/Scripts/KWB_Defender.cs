using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KWB_Defender : MonoBehaviour
{

    Rigidbody2D rb;
    private float time;
    private float seconds;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 1)
        {
            seconds++;
            time = 0;
        }

        if(seconds == 3)
        {
            rb.AddForce(transform.up * 15 , ForceMode2D.Impulse);
            seconds = 0;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "KWB_ball")
        {
            SceneManager.LoadScene("KWB_Scene2");
        }
    }
}
