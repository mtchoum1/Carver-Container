using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LKC_Score : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.name.Contains("Circle")){
            score++; 
            Destroy(col.gameObject);
            print(score); 
        }
        if(score == 1){
                SceneManager.LoadScene("LKC_Cup2");
            }
        if(score == 3){
                SceneManager.LoadScene("LKC_Win");
            } 
    }
}
