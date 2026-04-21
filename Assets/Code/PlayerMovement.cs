using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    float move;

    public float JumpForce;
    public bool IsJumping;

    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

  
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb2d.linearVelocity = new Vector2(move * Speed, rb2d.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);

            Debug.Log("Jump");
        }
    }
 
}
