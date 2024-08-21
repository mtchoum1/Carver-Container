using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KNK_SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           SceneManager.LoadScene("test2");
        }
        else
        {
           SceneManager.LoadScene("KNK_test");
        }
        if(Input.GetKey(KeyCode.H))
        {
           SceneManager.LoadScene("KNK_howtoplay");
        }
        else
        {
            SceneManager.LoadScene("KNK_test");
        }
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
