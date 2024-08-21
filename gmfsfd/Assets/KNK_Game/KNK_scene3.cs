using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KNK_scene3 : MonoBehaviour {
    public static float score = 0f;
    void OnGUI()
    {
        GUIStyle gs = new GUIStyle();
        gs.alignment = TextAnchor.LowerLeft;
        GUI.BeginGroup(new Rect(Screen.width / 2 - 200, 20, 400, 50));
        gs.normal.textColor = Color.yellow;
        gs.fontSize = 14;
        GUI.Box(new Rect(0, 0, 400, 25), "Score:" + score, gs);
        GUI.EndGroup();
    }
    void Update()
    {
      if(Input.GetKey(KeyCode.R))
      {
        SceneManager.LoadScene("KNK_test");
      } 
      else
      {
        SceneManager.LoadScene("Loading");
      } 
    }

}      

