using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] Transform leftWall;
    [SerializeField] Transform rightWall;

    private Rigidbody rb;
    private Vector3 direction;

    private void Start()
    {
        // Reference to rigidbody
        rb = GetComponent<Rigidbody>();
        // Set the ball to be moving right at the start
        direction = Vector3.right; 
    }

    private void FixedUpdate()
    {
        // Move the ball
        rb.linearVelocity = direction * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the ball collides with the right or left wall
        if (collision.transform == leftWall || collision.transform == rightWall)
        {
            // Get the wall's normal
            Vector3 wallNormal = collision.contacts[0].normal;

            // Use the dot product to decide the new direction
            // If the wall is facing the ball, the normal will point toward the ball
            float dotProduct = Vector3.Dot(direction, wallNormal);

            // If the dot product is negative, the ball is moving toward the wall
            if (dotProduct < 0)
            {
                // Reverse the direction after collision
                direction = -direction;
            }
        }
    }
}
