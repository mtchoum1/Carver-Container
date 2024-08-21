using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GGD_Cat : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpHeight;
    Rigidbody2D rb;
    public Sprite JumpSprite;
    public Sprite WalkSprite;
    public Sprite CrouchSprite;
    bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        canJump = false;
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void Jump()
    {
        rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * Time.deltaTime * speed;
        if(Input.GetButtonDown("Jump") && canJump == true)
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.Find("GGD_Foot").position, -transform.up, 1000);
        if(hit.collider != null)
        {
            if(hit.collider.CompareTag("Ground") && Vector3.Distance(hit.point, transform.Find("GGD_Foot").position) <= .1f)
            {
                canJump = true;
                GetComponent<SpriteRenderer>().sprite = WalkSprite;
            }
            else
            {
                canJump = false;
                GetComponent<SpriteRenderer>().sprite = JumpSprite;
            }
        }

        if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("GGD_Scene1");
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<SpriteRenderer>().sprite = CrouchSprite;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "GGD_Goal")
        {
            SceneManager.LoadScene("GGD_Scene3");
        }

        if(col.gameObject.name == "GGD_Lava")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GGD_Scene2");
        }

        if(col.gameObject.name == "GGD_Spike")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GGD_Scene3");
        }

        if(col.gameObject.name == "GGD_Goal2")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GGD_Scene4");
        }

        if(col.gameObject.name == "GGD_Lava2")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GGD_Scene3");
        }

        if(col.gameObject.name == "GGD_Lava3")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GGD_Scene4");
        }
    }
}
