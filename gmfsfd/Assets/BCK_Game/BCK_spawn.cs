using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCK_spawn : MonoBehaviour
{ 
public GameObject prefab = null;
   void OnCollisionEnter2D(Collision2D col)
   {
    Destroy(col.gameObject);
    BCK_Display.score = BCK_Display.score - 500;
    GameObject obj = (GameObject)Instantiate(prefab, new Vector2(-0.5f, -10.5f), transform.rotation);
   }	
}
