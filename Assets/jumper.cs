using UnityEngine;

public class jumper : MonoBehaviour
{
    public Rigidbody2D bird;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // add force to the bird
            bird.linearVelocity = Vector2.up * 5f; // Adjust the force as needed
        }
        if (bird.transform.position.y < -10f)
        {
            // Reset bird position if it falls below a certain point
            bird.transform.position = new Vector2(-2f, 0f); // Adjust the reset position as needed
            bird.linearVelocity = Vector2.zero; // Reset velocity
        }
    }
}
