using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMD_intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("CMD_bg_cooked").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("CMD_bg_cooked").GetComponent<BoxCollider2D>().enabled=false;
        GameObject.Find("CMD_bg_overcooked").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("CMD_bg_overcooked").GetComponent<BoxCollider2D>().enabled=false;
        GameObject.Find("CMD_bg_undercooked").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("CMD_bg_undercooked").GetComponent<BoxCollider2D>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        GameObject.Find("CMD_bg_intro").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("CMD_bg_intro").GetComponent<BoxCollider2D>().enabled=false;
    }
}
