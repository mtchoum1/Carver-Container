using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DAM_EndTxtScript : MonoBehaviour{
    [SerializeField] Text txt;
    void Start(){
        txt.text = "You scored: " + DAM_AddPoints.score + " point(s)!";
    }
}
