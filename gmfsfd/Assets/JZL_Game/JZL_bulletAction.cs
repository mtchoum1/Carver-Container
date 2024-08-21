using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JZL_bulletAction : MonoBehaviour
{
    GameObject pl;
    // Start is called before the first frame update
    void Start()
    {
        pl = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(!(coll.gameObject.name == "Player")&&!(coll.gameObject.tag == "Finish"))
        {
            Destroy(gameObject);
        }
            
        if(coll.gameObject.tag == "Player")
        {
            Destroy(coll.gameObject);
            
            Destroy(gameObject);
            pl.GetComponent<JZL_playermovement>().score += 10f;
            
        }

    }
}
