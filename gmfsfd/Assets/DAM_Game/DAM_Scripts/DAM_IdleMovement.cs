using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAM_IdleMovement : MonoBehaviour
{
    Vector3 direction = new Vector3(1f,0f,0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * 5f;
        if(transform.position.x >= 8f){
            direction *= -1f;
            transform.localScale = new Vector3(-0.5f,0.5f,1);
        }
        else if(transform.position.x <= -8f){
            direction *= -1f;
            transform.localScale = new Vector3(0.5f,0.5f,1);
        }
    }
}
