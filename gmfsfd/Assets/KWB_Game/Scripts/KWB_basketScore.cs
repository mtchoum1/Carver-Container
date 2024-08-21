using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KWB_basketScore : MonoBehaviour
{
    public float KWB_score;
    // Start is called before the first frame update
    void Start()
    {
        KWB_score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)  
    {        if(col.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            KWB_score++;
            print(KWB_score);
            SceneManager.LoadScene("KWB_Scene2");
        }
    }
}