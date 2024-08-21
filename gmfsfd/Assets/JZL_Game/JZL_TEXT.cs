using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JZL_TEXT : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "score " + GameObject.Find("Player").GetComponent<JZL_playermovement>().score;
        if (GameObject.Find("Player").GetComponent<JZL_playermovement>().hp <= 0)
        {
            GetComponent<UnityEngine.UI.Text>().text = "you died your score was " + GameObject.Find("Player").GetComponent<JZL_playermovement>().score;
        }
    }
}
