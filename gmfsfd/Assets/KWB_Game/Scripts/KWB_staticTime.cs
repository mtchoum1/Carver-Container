using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KWB_staticTime : MonoBehaviour
{
    public static float time;
    public static float count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 1)
        {
            count++;
            time = 0;
            print(count);
        }
        

        if (count == 30)
        {
            SceneManager.LoadScene("KWB_Scene4");
            count = 0;
        }
    }
}
