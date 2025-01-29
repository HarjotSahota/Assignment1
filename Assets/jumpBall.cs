using UnityEngine;

public class JumpBall : MonoBehaviour
{
    private Rigidbody rb;
    private bool isGrounded = true;
    public float jumpForce = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get Rigidbody at start
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // Prevent multiple jumps
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true; // Reset when touching ground
    }
}
