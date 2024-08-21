using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAM_PlayerMove : MonoBehaviour{
    public static Rigidbody2D rb;
    float moveSpeed;
    public float currentVelocity;
    public static bool isInWater;
    float smooth = 5f;
    float tiltAngle = 60f;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 0;
        isInWater = false;
    }
    void Update(){
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        Quaternion target = Quaternion.Euler(0,0,tiltAroundZ);
        transform.rotation= Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        if(Input.GetKeyDown("a")){
            transform.localScale = new Vector3(-1,1,1);
        }
        if(Input.GetKeyDown("d")){
            transform.localScale = new Vector3(1,1,1);
        }
        if(Input.GetKeyDown("left")){
            transform.localScale = new Vector3(-1,1,1);
        }
        if(Input.GetKeyDown("right")){
            transform.localScale = new Vector3(1,1,1);
        }
        if(transform.position.y < -3){
            DAM_AddPoints.hasGottenPoint = false;
            isInWater = true;
            transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0) * Time.deltaTime * moveSpeed;
            rb.gravityScale = 0;
            if(transform.position.y < -10){
            rb.velocity = new Vector2(0,0);
            }
            moveSpeed = 55f;
        }
        else{
            isInWater = false;
            rb.gravityScale = 4;
            transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * Time.deltaTime * (moveSpeed * 1/2);
        }
    }
}
