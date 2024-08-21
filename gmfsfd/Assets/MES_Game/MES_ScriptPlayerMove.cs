using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MES_ScriptPlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject playisUp;
    Collider colide;
    //float deaths = 1;
    public Animator movement;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        MES_ScriptDisplay.dead = false;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        rb.freezeRotation = true;
        movement = GetComponent<Animator>();
        colide = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {  
        movement.SetBool("MovingLeft", false);
        movement.SetBool("MovingRight", false);
        movement.SetBool("MovingUp", false);
        movement.SetBool("MovingDown", false);
        sr.flipY = false;
        rb.velocity = new Vector2(0f, 0f);
        colide = GetComponent<Collider>();
        if(Input.GetKey("left")) {
            //Debug.Log("left");
            rb.velocity = new Vector2(-3f, 0f);
            sr.flipX = true;
            movement.SetBool("MovingLeft", true);
            movement.SetBool("MovingRight", false);
            movement.SetBool("MovingUp", false);
            movement.SetBool("MovingDown", false);
        } 
        if(Input.GetKey("right")) {
            //Debug.Log("right");
            rb.velocity = new Vector2(3f, 0f);
            sr.flipX = false;
            movement.SetBool("MovingLeft", false);
            movement.SetBool("MovingRight", true);
            movement.SetBool("MovingUp", false);
            movement.SetBool("MovingDown", false);
        } 
        if(Input.GetKey("up")) {
            //Debug.Log("up");
            sr.flipY = false;
            rb.velocity = new Vector2(0f, 3f);
            colide = playisUp.GetComponent<Collider>();
            movement.SetBool("MovingLeft", false);
            movement.SetBool("MovingRight", false);
            movement.SetBool("MovingUp", true);
            movement.SetBool("MovingDown", false);
        } 
        if(Input.GetKey("down")) {
            //Debug.Log("down");
            rb.velocity = new  Vector2(0f, -3f);
            sr.flipY = true;
            colide = playisUp.GetComponent<Collider>();
            movement.SetBool("MovingLeft", false);
            movement.SetBool("MovingRight", false);
            movement.SetBool("MovingUp", false);
            movement.SetBool("MovingDown", true);
        } 
    }
    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.name.Contains("Car")) {
            Destroy(col.gameObject);
            transform.position = new Vector3(-8,0,0);
            rb.angularVelocity = 0;
            //Debug.Log("stop it");
            //deaths++;
            //Debug.Log(deaths);
            if(GameObject.Find("Heart2") == null){ 
                Destroy(GameObject.Find("Heart1"));
                //SceneManager.LoadScene("MES_SceneMain");
                MES_ScriptDisplay.dead = true;
                SceneManager.LoadScene("MES_Scene_GameOver");
                //deaths++;
            } else if(GameObject.Find("Heart3") == null) {
                Destroy(GameObject.Find("Heart2"));
                //deaths++;
            } else if(GameObject.Find("Heart4") == null) {
                Destroy(GameObject.Find("Heart3"));
                //deaths++;
            } else if(GameObject.Find("Heart5") == null) {
                Destroy(GameObject.Find("Heart4"));
                //deaths++;
            } else if(GameObject.Find("Heart5") != null) {
                Destroy(GameObject.Find("Heart5"));
                //deaths++;
                //SceneManager.LoadScene("Loading");
            }
        }
    }
}
