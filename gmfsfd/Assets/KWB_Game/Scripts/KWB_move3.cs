using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KWB_move3 : MonoBehaviour
{
    private Rigidbody2D KWB_basketball;
    private GameObject KWB_camBody;
    private GameObject planet;
    private float KWB_dubCheck = 3;
    private float KWB_cooldown;
    private Vector3 distance;
    public float force = 0.8f;
    [SerializeField] private float KWB_thrust = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        KWB_basketball = gameObject.GetComponent<Rigidbody2D>();
        KWB_camBody = GameObject.Find("KWB_camBody");
        planet = GameObject.Find("planet");
    }

    // Update is called once per frame
    void Update()
    {
        KWB_camBody.transform.position = new Vector2(KWB_basketball.position.x, KWB_basketball.position.y);
        distance = new Vector3(planet.GetComponent<Rigidbody2D>().position.x - KWB_basketball.position.x, planet.GetComponent<Rigidbody2D>().position.y - KWB_basketball.position.y, 0 ).normalized ;
        KWB_basketball.AddForce(force * distance / 40f, ForceMode2D.Force);

        KWB_cooldown += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (KWB_cooldown >= 0.5f)
            {
                KWB_basketball.velocity = new Vector2 (KWB_basketball.velocity.x, 0f);
                KWB_basketball.AddForce(transform.up * KWB_thrust * 1.8f, ForceMode2D.Impulse);
                KWB_cooldown = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (KWB_cooldown >= 0.5f)
            {
                KWB_basketball.velocity = new Vector2 (KWB_basketball.velocity.x, 0f);
                KWB_basketball.AddForce(-transform.up * KWB_thrust * 1.8f, ForceMode2D.Impulse);
                KWB_cooldown = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))  
        {
            if (KWB_dubCheck != 1)
            {
                KWB_basketball.velocity = new Vector2 (0f, KWB_basketball.velocity.y);
                KWB_dubCheck = 1;
            }
            KWB_basketball.AddForce(Vector3.left * KWB_thrust , ForceMode2D.Impulse);
            
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (KWB_dubCheck != 2)
            {
                KWB_basketball.velocity = new Vector2 (0f, KWB_basketball.velocity.y);
                KWB_dubCheck = 2;
            }
            KWB_basketball.AddForce(Vector3.right * KWB_thrust , ForceMode2D.Impulse);
            
        }
    }
}
