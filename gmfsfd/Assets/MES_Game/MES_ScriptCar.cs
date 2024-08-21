using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MES_ScriptCar : MonoBehaviour
{
    SpriteRenderer sr;
    Animator carColor;
    //Rigidbody2D rb;
    // float deaths = 0;
    // GameObject heart1;
    // public GameObject heart5;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        carColor = GetComponent<Animator>();
        if(sr.color == Color.blue) {
            carColor.SetBool("colorBlue", true);
        } else if(sr.color == Color.green) {
            carColor.SetBool("colorGreen", true);
        }
        sr.color = Color.white;
        //rb = GetComponent<Rigidbody2D>();
        // rb.AddForce(transform.up * 100f);
        // GameObject heart1 = GameObject.Find("Heart1");
        // GameObject heart5 = GameObject.Find("Heart5");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D hit) {
        // if(hit.gameObject.name.Contains("Player")) {
        //     Debug.Log("stop it");
        //     if(deaths == 1){ 
        //         Destroy(GameObject.Find("Heart5"));
        //     } if(deaths == 2) {
        //         Destroy(GameObject.Find("Heart4"));
        //     } if(deaths == 3) {
        //         Destroy(GameObject.Find("Heart3")); 
        //     } if(deaths == 4) {
        //         Destroy(GameObject.Find("Heart2"));
        //     } if(deaths == 5) {
        //     }
        // }
    }
}
