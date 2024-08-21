using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SEC_Reticle : MonoBehaviour
{
    GameObject timer;
    GameObject scoreText;
    GameObject healthText;
    public static float time;
    public static float score;
    public static bool dead;
    public static float health;
    public GameObject heart1;
    public GameObject heart2;
    public bool gameActive;
    // Start is called before the first frame update
    void Start()
    {
        time = 30;
        dead = false;
        score = 0;
        health = 2;
        if (gameActive)
        {
            timer = GameObject.Find("Timer");
            scoreText = GameObject.Find("Score");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        transform.position = Camera.main.ScreenToWorldPoint(mPos);
        if (gameActive)
        {
            time += -Time.deltaTime;
            timer.GetComponent<Text>().text = "Time Left: " + Mathf.Round(time);
            scoreText.GetComponent<Text>().text = "Score: " + score;
            if (health == 1)
            {
                heart2.GetComponent<Animator>().SetBool("broken", true);
                if (Time.deltaTime>= 0.2f)
                {
                    Destroy(heart2);
                }
            }
            else if (health == 0)
            {
                heart1.GetComponent<Animator>().SetBool("broken", true);
                if (Time.deltaTime>=0.2f)
                {
                    Destroy(heart1);
                }
            }
            if (time <= 0 || health <= 0)
            {
                SceneManager.LoadScene("SEC_GameOver");
            }
        }
    }
}
