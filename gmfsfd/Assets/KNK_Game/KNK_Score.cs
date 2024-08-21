using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KNK_Score : MonoBehaviour
{
    Rigidbody2D rb; //Declares a variable to hold the paddles RigidBody2D
    SpriteRenderer sr; //holds the paddles SpriteRenderer
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //set rb to the RigidBody2D of the paddle
        sr = GetComponent<SpriteRenderer>();
        GameObject paper = GameObject.Find("KNK_paperstraight");
        paper.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 2f);
        KNK_Display.score = 0;
        
    }
}

    // Update is called once per frame
    //void Update()
    //{
    //void OnCollisionEnter2D(Collision2D col);
    //}
    //if(col.gameObject.name == "KNK_paperstraight");
    //{
        //KNK_Display.score++;
    //}
 
