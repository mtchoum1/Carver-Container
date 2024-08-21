using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KWB_basketCheck3 : MonoBehaviour
{
    public float KWB_score2;
    // Start is called before the first frame update
    void Start()
    {
        KWB_score2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)  

    {    
        if(col.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            KWB_score2++;
            print(KWB_score2);
            SceneManager.LoadScene("KWB_Scene4");
        }
    }
}
