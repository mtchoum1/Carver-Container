using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MES_ScriptDisplay : MonoBehaviour
{
    public static bool dead = false;
    public float topLocation = 20f;
    private int scale = 0;
    // Start is called before the first frame update
    void Start()
    {
        scale = Screen.width;
    }
    void OnGUI()
    {
       
        GUIStyle gs = new GUIStyle();
        gs.alignment = TextAnchor.MiddleCenter;
        GUI.BeginGroup(new Rect(0, topLocation, Screen.width , 20* scale / 425));
        gs.normal.textColor = Color.black;
        gs.fontSize = 15*scale/425;
        if(dead == true) {
            GUI.Box(new Rect(0, 20, Screen.width, 20* scale / 425), "Oh No! You Ran Out of Hearts!", gs);
        } else {
            GUI.Box(new Rect(0, 20, Screen.width, 20* scale / 425), "You Beat The Game!", gs);
        }
        //GUI.Box(new Rect(0, 0, 400, 45* scale / 425), "" + message, gs);
        GUI.EndGroup();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
