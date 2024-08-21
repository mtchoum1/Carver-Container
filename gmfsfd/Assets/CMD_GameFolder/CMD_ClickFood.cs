using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMD_ClickFood : MonoBehaviour
{
    Animator anim;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        anim=gameObject.GetComponent<Animator>();
        anim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Debug.Log( "click " + gameObject.name );
        
        if( gameObject.name == "CMD_food_Carton") {
            GameObject.Find("CMD_food_Egg").GetComponent<CMD_ClickFood>().OnMouseDown();
        }
        else {
            anim.enabled = true;
            GameObject.Find("CMD_bg_oClosed_cOpen").GetComponent<CMD_Baking>().AddIngredient();
        }
        
       }
}
