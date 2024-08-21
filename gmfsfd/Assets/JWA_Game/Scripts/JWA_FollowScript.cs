using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JWA_FollowScript : MonoBehaviour
{
    public Rigidbody2D targ;
    public GameObject player;
    [SerializeField] float followStrength;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        targ = player.GetComponent<Rigidbody2D>();
        //targ.transform.position.x = targ.transform.position.x + 3;
        //Debug.Log(targ.transform.position.x);
        //Debug.Log("hello");
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject Player = GameObject.Find("Player");
        transform.position = Vector2.MoveTowards(transform.position, targ.transform.position, followStrength);
        //Debug.Log("hello");
    }
}
