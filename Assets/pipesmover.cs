using UnityEngine;

public class pipesmover : MonoBehaviour
{
    // Update is called once per frame
    public GameObject pipePrefab; // Assign the pipe prefab in the Inspector
    
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * 5f; // Adjust speed as needed

        // Destroy pipe if it goes off-screen (e.g., x < -15)
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}
