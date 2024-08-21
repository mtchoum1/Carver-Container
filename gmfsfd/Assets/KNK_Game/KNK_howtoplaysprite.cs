using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KNK_howtoplaysprite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Input.GetKey(KeyCode.B))
        {
            SceneManager.LoadScene("KNK_test");
        }
    }

    // Update is called once per frame
    //void Update()
    //{
        
   // }
}
