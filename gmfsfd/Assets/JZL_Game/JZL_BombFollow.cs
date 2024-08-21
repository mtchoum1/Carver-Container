using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JZL_BombFollow : MonoBehaviour
{
    Rigidbody2D rb;
    public int health;
    [HideInInspector]
    public GameObject player;
    [HideInInspector]
    public AudioSource soundManager;
    private bool collided = false;
    
    // Start is called before the first frame update
    void Start()
    {
        soundManager = GetComponent<AudioSource>();
        player = GameObject.Find("Player");
        transform.position = new Vector2( Random.Range(-51, 50), Random.Range(-36, 36));
        rb = this.GetComponent<Rigidbody2D>();
        health = 3;
    }

    // Update is called once per frame
    void Update()
        
    {
        if (!collided)
        {
            Vector2 direction = (player.transform.position) - transform.position;
            float angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
            float radAng = Mathf.Atan2(direction.y, direction.x);

            rb.MovePosition((Vector2)transform.position + (new Vector2(Mathf.Cos(radAng), Mathf.Sin(radAng)) * Mathf.Rad2Deg) * 0.005f);
        }
        

        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.name == "Player")
        {

            soundManager.Play();
            if (!collided)
            {
                player.GetComponent<JZL_playermovement>().hp -= 1;
            }
            

            collided = true;
            Destroy(gameObject,1f);
            //sound is from mixkit free sound assets
        }
    }
}
