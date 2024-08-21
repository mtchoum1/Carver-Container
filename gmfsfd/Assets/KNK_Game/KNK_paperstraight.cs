using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KNK_paperstraight : MonoBehaviour 
{       Rigidbody2D rb; 
    void Start () {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //float vx = Random.Range(-3f, 3f); //Sets vx to random number between -3 to 3
        rb.velocity = new Vector2(-2f, -2f); //Sets the velocity of the object
        //Display.score = 0;
	}
	void Update () {
        //if (Input.GetKey(KeyCode.Space))
        {
            //SceneManager.LoadScene(0); //Loads the scene
        }	
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "floor")  //Checks if object collides with the floor
        {
        rb.velocity = new Vector2(2f,2f);
        }
        if(col.gameObject.name == "KNK_roundtable")
        {
        rb.velocity = new Vector2(2f,2f);
        }
        if(col.gameObject.name == "playeridle")
        {
        //Display.score++;
        }
    }
}
