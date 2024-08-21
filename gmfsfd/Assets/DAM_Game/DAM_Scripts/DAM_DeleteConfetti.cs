using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAM_DeleteConfetti : MonoBehaviour
{
    private float killConfettiTimer;
    private int theTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        killConfettiTimer += Time.deltaTime;
        if(killConfettiTimer >= 1){
            killConfettiTimer = 0;
            theTimer++;
        }
        if(theTimer == 3){
            theTimer = 0;
            Destroy(gameObject);
        }

    }
}
