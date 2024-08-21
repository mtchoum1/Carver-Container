using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KNK_Displaytimer : MonoBehaviour {
    public static float score = 30f;
    void OnGUI()
    {
        GUIStyle gs = new GUIStyle();
        gs.alignment = TextAnchor.UpperLeft;
        GUI.BeginGroup(new Rect(Screen.width / 2 - 200, 20, 400, 50));
        gs.normal.textColor = Color.yellow;
        gs.fontSize = 14;
        GUI.Box(new Rect(0, 0, 400, 25), "Time:" + score, gs);
        GUI.EndGroup();
    }
}
