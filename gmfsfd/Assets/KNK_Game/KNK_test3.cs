using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
