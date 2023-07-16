using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Playermovement : MonoBehaviour
{
    private float horizontalMove = 0;
    private float verticalMove = 0;
    public float runSpeedHorizontal = 2;
    public float runSpeedVertical = 3;
    public float runSpeed = 1;
    Rigidbody2D rgdbdy2D;
    public Joystick joystick;
    public float jumpForce = 3;
    
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rgdbdy2D = GetComponent<Rigidbody2D>();
    }
   
    // Update is called once per frame
   /// <summary>
   /// The Update function updates the position of the game object based on the horizontal and vertical
   /// movement values obtained from a joystick input.
   /// </summary>
    void Update()
    {
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;

        

        if (horizontalMove > 0)
        {
            spriteRenderer.flipX = false;
            
        }

        if (horizontalMove < 0)
        {
            spriteRenderer.flipX = true;
            
        }

        transform.position += new Vector3(horizontalMove, verticalMove, 0) * Time.deltaTime * runSpeed;
    }

    public void jump()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }
}
