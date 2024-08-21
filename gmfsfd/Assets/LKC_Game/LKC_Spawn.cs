using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LKC_Spawn : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
         GameObject obj = Instantiate(prefab, new Vector3(Random.Range(-7.91f, 7.94f), 4.04f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
     
}
