using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JDQ_Move : MonoBehaviour
{
    public float moveSpeed;
    private float timer;
    private bool buttonpress;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


       if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (timer <= 0 && GetComponent<Animator>().GetBool("Stun"))
        {
            GetComponent<Animator>().SetBool("Stun", false);
            moveSpeed = 5;
        }
        transform.position += (new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0)* moveSpeed)* Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.collider.CompareTag("obstacles"))
        {
            moveSpeed = 0;
            timer = 1;
            GetComponent<Animator>().SetBool("Stun", true);
        }
        if(col.collider.CompareTag("Goal"))
        {
            SceneManager.LoadScene("JDQ_WinScreen");
        }
    }
}
