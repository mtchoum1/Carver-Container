using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JWA_InstructionsDestroy : MonoBehaviour
{
    public static GameObject Instructions;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject.Find("UpKey").SetActive(false);
        GameObject.Find("RightLeftKeys").SetActive(false);
        //Destroy(GameObject.Find("Instructions"));
    }
}
