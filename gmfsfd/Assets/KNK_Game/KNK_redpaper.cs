using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KNK_redpaper: MonoBehaviour
{       Rigidbody2D rb;
        Collision2D col;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-2f,-2f);
    }

    // Update is called once per frame
    //void Update()
    void OnCollisionEnter2D(Collision2D col)
    { 
         if(col.gameObject.name == "floor")
        {
        rb.velocity = new Vector2(2f,2f);
        }
        if(col.gameObject.name == "KNK_roundtable")
        {
        rb.velocity = new Vector2(2f,2f);
        }
        if(col.gameObject.name == "KNK_playeridle")
        {
        SceneManager.LoadScene("test3");
        }
    
    } 
   
}
