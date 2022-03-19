using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int speed = 50;
    public int jump = 200;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.D)){
            rb.AddForce(Vector3.right * speed);
        }

        else if(Input.GetKeyDown(KeyCode.A)){
            rb.AddForce(Vector3.left * speed);
        }

        else if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(Vector3.up * jump);
        }



        
            
        
        
        
    }
}
