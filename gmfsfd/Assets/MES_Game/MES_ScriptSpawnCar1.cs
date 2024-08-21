using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MES_ScriptSpawnCar1 : MonoBehaviour
{
    public GameObject carPref;
    public float interval = 1f;
    public float xVal = 1f;
    public float yVal = 1f;
    public float yVel = 1f;
    public float speedMin = 0f;
    public float speedMax = 0f;
    float speed = 0f;
    float time = 0.0f;
    float ranColor = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; 
        if(time >= interval) {
            //Debug.Log("summoned! gaS-PAH");
            GameObject obj = (GameObject)Instantiate(carPref, new Vector2(xVal,yVal), Quaternion.identity);
            time = 0.0f;
            speed = Random.Range(speedMin, speedMax); 
            obj.GetComponent<Rigidbody2D>().AddForce(transform.up * yVel * speed);
            ranColor = Random.Range(1,4);
            if(ranColor == 2) {
                obj.GetComponent<SpriteRenderer>().color = Color.blue;
            } else if (ranColor == 3) {
                obj.GetComponent<SpriteRenderer>().color = Color.green;
            }
        }
    }
}
