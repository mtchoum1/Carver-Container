using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class JZL_playermovement : MonoBehaviour
{
    Rigidbody2D rb;
    float h;
    float v;
    public float angle;
    public Vector2 movement;
    public float runSpeed = 20.0f;

    public float score = 0f;

    public float hpLossPerSec;
    public int hp = 3;



    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Invoke("die", 3f);
           
            



        }
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) - 90f;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 20f * Time.deltaTime);

        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        movement = new Vector2(h, v);
        if (Input.GetKeyDown("q"))
        {
            SceneManager.LoadScene("Loading");
        }
        



    }
    private void FixedUpdate()
    {
        moveCharacter(movement);

    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * runSpeed * Time.deltaTime));
    }
    void die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("SampleScene");
    }
}
