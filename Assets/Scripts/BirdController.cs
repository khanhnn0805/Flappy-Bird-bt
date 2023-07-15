using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
       
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();     
    }

    // Update is called once per frame
    void Update()
    {
        bool isTab = Input.GetKeyDown(KeyCode.Space);

        if(isTab)
        {
            Jump();

        }    
    }
    protected void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }    
}
