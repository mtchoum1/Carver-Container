using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DAM_AddPoints : MonoBehaviour
{
    [SerializeField] Text txt;
    public GameObject prefab;
    public static int score;
    public static bool hasGottenPoint;

    // Start is called before the first frame update
    void Start()
    {
        hasGottenPoint = false;
        txt.text = "Score: ";
        score = 0;
    }
    void OnTriggerEnter2D(Collider2D other){
        if(hasGottenPoint == false){
            hasGottenPoint = true;
            score++;
            DAM_PlayerMove.rb.velocity = new Vector2((Input.GetAxis("Horizontal")) * 1/2,-5);
            txt.text = "Score: " + score;
            for(int i = 0; i <= 15; i++){
                GameObject theConfetti = Instantiate(prefab, new Vector3(0,Random.Range(25f,39f),0), Quaternion.identity);
                theConfetti.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f), 1);
                theConfetti.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-15f,15f), Random.Range(-3f,3f)), ForceMode2D.Impulse);
            }
        }
    }
}
