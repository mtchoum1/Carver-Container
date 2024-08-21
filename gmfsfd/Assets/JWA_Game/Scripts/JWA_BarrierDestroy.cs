using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class JWA_BarrierDestroy : MonoBehaviour
{
    static int[] scenes;
    int randomScene;
    public int finalRandomNum;
    public static int trashCount;
    static int pastScene;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "You have taken out the trash " + trashCount + " times.";
        //DontDestroyOnLoad(scoreText);
        if(scenes == null)
        {
            scenes = new int[]{1,2,3,4,5,6,7}; //add new levels to array
        }
    }
    /*public void sceneLoad()
    {
        randomScene = UnityEngine.Random.Range(0, 7);
        finalRandomNum = scenes[randomScene];
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player")
        {
            trashCount++;
            Destroy(col.gameObject);
            Destroy(GameObject.Find("Trash"));
            randomScene = UnityEngine.Random.Range(0, 7);
            finalRandomNum = scenes[randomScene];
            //pastScene = finalRandomNum;
               while(pastScene == finalRandomNum)
                {
                    randomScene = UnityEngine.Random.Range(0, 7);
                    finalRandomNum = scenes[randomScene];
                } 
            
            pastScene = finalRandomNum;
            SceneManager.LoadScene("JWA_Level"+ finalRandomNum);
            if(finalRandomNum == 1)
            {
                GameObject.Find("Instructions").SetActive(false);
                //GameObject.Find("UpKey").SetActive(false);
                //GameObject.Find("RightLeftKeys").SetActive(false);
            }
            //print(finalRandomNum);
        }
    }

}
