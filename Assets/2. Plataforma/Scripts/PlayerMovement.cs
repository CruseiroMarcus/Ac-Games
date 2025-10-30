using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 7;
    public float jumpForce = 35;
    private Rigidbody2D rb;
    private bool isGrounded;
    public float gravityScale = 10;
    public float fallingGravityScale = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        if(rb.linearVelocity.y >= 0)
        { 
            rb.gravityScale = gravityScale;
        }
        else if( rb.linearVelocity.y < 0)
        {
            rb.gravityScale = fallingGravityScale;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.contacts[0].normal.y > 0.5f)
            isGrounded = true;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        isGrounded = false;
    }

}