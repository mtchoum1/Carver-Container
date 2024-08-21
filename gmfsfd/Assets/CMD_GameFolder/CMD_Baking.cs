using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CMD_Baking : MonoBehaviour
{
    int score;
    float ovenStartTime;
    float bakeTime;
    float gameStartTime;
    int ovenState;
    // Start is called before the first frame update
    void Start()
    {
        ovenState = 0;
        score =0;
        gameStartTime = Time.time;
        ovenStartTime = 0.0F;
        bakeTime = 0.0F;
        GameObject.Find("CMD_food_FinishedUndercooked").GetComponent<Animator>().enabled = false;
        GameObject.Find("CMD_food_FinishedOvercooked").GetComponent<Animator>().enabled = false;
        GameObject.Find("CMD_food_FinishedCooked").GetComponent<Animator>().enabled = false;
         GameObject.Find("CMD_food_FinishedUndercooked").GetComponent<Renderer>().enabled = false;
        GameObject.Find("CMD_food_FinishedOvercooked").GetComponent<Renderer>().enabled = false;
        GameObject.Find("CMD_food_FinishedCooked").GetComponent<Renderer>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if( ovenStartTime > 0.0F) {
            bakeTime = Time.time - ovenStartTime;
            if( ( bakeTime > 1.0 ) && ( bakeTime > 2.0 ) ) {
                ovenState = 1;
            }
            if( ( bakeTime > 3.0 ) && ( bakeTime > 4.0 ) ) {
                ovenState = 2;
            }
            if( ( bakeTime > 10.0 ) && ( bakeTime > 10.0 ) ) {
                ovenState = 3;
                GameObject.Find("CMD_food_FinishedOvercooked").GetComponent<Renderer>().enabled = true;
            }

            if( ovenState == 0 ){
                GameObject.Find("CMD_bg_oSemiOpen_cOpen").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("CMD_bg_oOpen_cOpen").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find("CMD_bg_oClosed_cOpen").GetComponent<SpriteRenderer>().enabled = false;
            }
            else if( ovenState == 1) {
                GameObject.Find("CMD_food_Egg").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find("CMD_food_ButterClosed").GetComponent<SpriteRenderer>().enabled = false;
            }
            else if( ovenState == 2) {
                GameObject.Find("CMD_object_Bowl").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find("CMD_bg_oSemiOpen_cOpen").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find("CMD_bg_oOpen_cOpen").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find("CMD_bg_oClosed_cOpen").GetComponent<SpriteRenderer>().enabled = true;
            }
            else if( ovenState == 3 ) {
                GameObject.Find("CMD_bg_oSemiOpen_cOpen").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find("CMD_bg_oOpen_cOpen").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("CMD_bg_oClosed_cOpen").GetComponent<SpriteRenderer>().enabled = false;
            }
            //if( bakeTime > 12.0 ) { 
            //}       
        }   
        //Debug.Log( "bake time " + bakeTime );

    }
    public void AddIngredient()
    {
        score++;
        Debug.Log( "AddIngredient " + score );
        if( score >= 5 ) {
            GameObject.Find("CMD_object_Bowl").GetComponent<Animator>().enabled = true;
            ovenStartTime = Time.time;
        }
    }
    public void OnMouseDown()
    {
        float bakeTimeHolder = bakeTime;
        ovenStartTime=0.0f;
        Debug.Log( "bake time " + bakeTime );
        if(bakeTimeHolder<9f){
            ovenState=3;
            Debug.Log( "undercooked" );
            GameObject.Find("CMD_food_FinishedUndercooked").GetComponent<Renderer>().enabled = true;
            GameObject.Find("CMD_food_FinishedUndercooked").GetComponent<Animator>().enabled = true;
            GameObject.Find("CMD_bg_undercooked").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("CMD_bg_undercooked").GetComponent<BoxCollider2D>().enabled=true;
            SceneManager.LoadScene("Loading");
        
        }else if(bakeTimeHolder>11f){
            Debug.Log( "overcooked" );
            GameObject.Find("CMD_food_FinishedOvercooked").GetComponent<Renderer>().enabled = true;
            GameObject.Find("CMD_food_FinishedOvercooked").GetComponent<Animator>().enabled = true;
            ovenState=3;
            GameObject.Find("CMD_bg_overcooked").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("CMD_bg_overcooked").GetComponent<BoxCollider2D>().enabled=true;
            SceneManager.LoadScene("Loading");
        }else{
            Debug.Log( "just right" );
            ovenState=3;
            GameObject.Find("CMD_food_FinishedCooked").GetComponent<Renderer>().enabled = true;
            GameObject.Find("CMD_food_FinishedCooked").GetComponent<Animator>().enabled = true;
            GameObject.Find("CMD_bg_cooked").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("CMD_bg_cooked").GetComponent<BoxCollider2D>().enabled=true;
            SceneManager.LoadScene("Loading");
        }
    }
}
