using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool isSprinting;
    public float movementSpeed;
    float horizontalInput;
	Rigidbody2D rigidbody2DCompontent;

    public bool isJumping;
    public float jumpHeight;
    

	// Start is called before the first frame update
	void Start()
    {
        rigidbody2DCompontent = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

		if (Input.GetKey(KeyCode.LeftShift))
		{
            isSprinting = true;
		}

		if (Input.GetButtonDown("Jump") && isJumping == false)
		{
            rigidbody2DCompontent.AddForce(new Vector2(rigidbody2DCompontent.velocity.x, jumpHeight));
		}

        

    }

	private void FixedUpdate()
	{
        if(horizontalInput < 0)
		{
            rigidbody2DCompontent.transform.rotation = new Quaternion(0, 1, 0, 0);
		}

        if (horizontalInput > 0)
        {
            rigidbody2DCompontent.transform.rotation = new Quaternion(0, 0, 0, 0);
        }

        rigidbody2DCompontent.velocity = new Vector2(horizontalInput * movementSpeed , rigidbody2DCompontent.velocity.y);

		if (isSprinting)
		{
            rigidbody2DCompontent.velocity = new Vector2(horizontalInput * movementSpeed * 2, rigidbody2DCompontent.velocity.y);
            isSprinting = false;
        }

         

        

		
    }
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Environment"))
		{
            isJumping = false;
		}
	}
	private void OnCollisionExit2D(Collision2D other)
	{
        if (other.gameObject.CompareTag("Environment"))
        {
            isJumping = true;
        }

      
    }
}
