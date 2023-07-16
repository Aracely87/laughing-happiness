using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* The PlayerMove class controls the movement of a player character in a 2D game using a Rigidbody2D
component and a joystick input. */
public class PlayerMove : MonoBehaviour
{

    private float horizontalMove = 0;
    private float verticalMove = 0;
    public float runSpeed = 2;
    public float jumpSpeed= 3;
    Rigidbody2D rd2D;
    public bool betterjump = false;
    public float fallMultipler = 0.5f;
    public float lowjumpMultipler = 1f;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        rd2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("right"))
        {
            rd2D.velocity = new Vector2(runSpeed, rd2D.velocity.y);
        }
        else if (Input.GetKey("left"))
        {
            rd2D.velocity = new Vector2(-runSpeed, rd2D.velocity.y);
        }
        else
        {
            rd2D.velocity = new Vector2(0, rd2D.velocity.y);
        }
        if(Input.GetKey("space")&& isGrounded.isGrounde) 
        {
            rd2D.velocity = new Vector2(rd2D.velocity.x, jumpSpeed);
        }
        if (betterjump)
        {
            if (rd2D.velocity.y<0)
            {
                rd2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultipler) * Time.deltaTime;
            }
            if (rd2D.velocity.y >0 && !Input.GetKey("space"))
            {
                rd2D.velocity += Vector2.up * Physics2D.gravity.y * (lowjumpMultipler) * Time.deltaTime;
            }
        }
    }
}
