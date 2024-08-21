using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JZL_SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float SpawnRate = 0.6f;
    public float timeE=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeE > SpawnRate)
        {
            Instantiate(enemyPrefab);
            timeE = 0f;
        }
        timeE += Time.deltaTime;
    }
}
