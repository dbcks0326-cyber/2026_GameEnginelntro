using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PLAYERCONTROLLER : MonoBehaviour
{
    private Vector2 moveInput;
    public float moveSpeed = 50f;
    public float jumpForce = 60f;
    private Rigidbody2D rb;
    private Animator myAnimator;



    void Start()
    
    {
        rb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myAnimator.SetBool("moce", false);
    }
    public void OnMove(InputValue value)
    { moveInput = value.Get<Vector2>();  }

    public void OnJump(InputValue value)
    {
        if (value.isPressed)
        { rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); }
    }
   
    // Update is called once per frame
    void Update()
    {

        if (moveInput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (moveInput.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (moveInput.magnitude > 0)
        {
            myAnimator.SetBool("move", true);
        }
        else
        {
            myAnimator.SetBool("move", false);

        }
        transform.Translate(Vector3.right * moveSpeed * moveInput.x * Time.deltaTime);
    }

   

}
