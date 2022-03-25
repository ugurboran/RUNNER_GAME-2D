using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int speed = 100;
    public int jump = 2000;
    Rigidbody2D rb;
     
    // Start is called before the first frame update
    void Start()
    {
        
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.RightArrow)){
            rb.AddForce(Vector3.right * speed);
        }

        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            
            rb.AddForce(Vector3.left * speed);
        }

        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            rb.AddForce(Vector3.up * jump);
        }



        
            
        
        
        
    }
}
