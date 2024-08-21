using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAM_MakeJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D isPlayer){
        if(isPlayer.name == "DAM_PC" && DAM_PlayerMove.isInWater == true){
            DAM_PlayerMove.rb.AddForce(transform.up * 55f, ForceMode2D.Impulse);
        }
    }
}
