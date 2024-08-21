using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGD_Dog : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject prefab;
    public float interval = 3;
    float time = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(new Vector2(-300f, 0f));
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time >= interval)
        {
            GameObject obj = (GameObject)Instantiate(prefab, transform.position, transform.rotation);
            time = 0f;
        }
    }

     void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "GGD_Wall")
        {
            Destroy(gameObject);
        }
    }
}
