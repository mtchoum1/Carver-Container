using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MJB_Canvas : MonoBehaviour
{
    public static float timer = 0;
    bool bogus = false;
    bool specialSpawned = false;
    public static bool isSpawning = false;

    float gameTimer;
    GameObject txtGameOver;

    float endTimer;

    bool stop;

    public static bool map = false; 

    public static bool tutorialDone = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("TimeScore").SetActive(false);

        gameTimer = 0;
        txtGameOver = GameObject.Find("GameOver");

        txtGameOver.SetActive(false);

        stop = false;
        endTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(stop == false)
        {
            gameTimer += Time.deltaTime;
        }

        if(MJB_PlayerMove.attackCharge >= 5 && tutorialDone == false)
        {
            transform.GetChild(4).gameObject.SetActive(true);
            tutorialDone = true;
        }

        timer += Time.deltaTime;
        if(timer >= 5 && bogus == false)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);

            bogus = true;
            isSpawning = true;
        }

        if(gameTimer >= 13 && specialSpawned == false)
        {
            MJB_SpecialScript.spawnSpecial = true;
            specialSpawned = true;
            isSpawning = false;
        }
        
        if(gameTimer >= 35)
        {
            txtGameOver.SetActive(true);
            txtGameOver.transform.GetChild(0).GetComponent<Text>().text = "Game Over\nScore: " + MJB_TimeScore.score + " Hits: " + MJB_TimeScore.hits + "\nEfficiency: " + MJB_TimeScore.score / MJB_TimeScore.hits;

            gameTimer = 0;
            stop = true;

            SceneManager.LoadScene("Loading");
        }

        if(stop == true)
        {
            endTimer += Time.deltaTime;
            if(endTimer >= 5)
            {
                SceneManager.LoadScene("Loading");
            }
        }
    }
}
