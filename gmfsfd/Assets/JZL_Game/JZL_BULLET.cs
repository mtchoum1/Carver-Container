using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JZL_BULLET : MonoBehaviour
{
    private Transform ToPoint;
    public Transform point;
    public GameObject bullet;
    public float reloadSpeed = 0.5f;
    public float timeSince=0f;   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        if(Input.GetMouseButton(0))
        {
            if (timeSince > reloadSpeed)
            {
                fire();
                timeSince = 0f;
            }
            
        }
        timeSince += Time.deltaTime;



    }
    void fire()
    {
        GameObject shotBullet = Instantiate(bullet, point.position, GameObject.Find("Player").transform.rotation);
        Rigidbody2D rb = shotBullet.GetComponent<Rigidbody2D>();

        rb.AddForce(point.up*40f, ForceMode2D.Impulse);
       
    }

}
