using UnityEngine;

public class swinger : MonoBehaviour
{
    // Attach pipe prefab in the Inspector
    public GameObject pipePrefab;
    public float spawnInterval = 2f;
    private float timer = 0f;
    public Transform pipesParent; // Assign this in the Inspector (optional)

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            // Instantiate the pipePrefab at a random Y position
            float randomY = Random.Range(-4.0f, 4.0f);
            float randomX = Random.Range(4.0f, 10.0f);
            Vector3 spawnPosition = new Vector3(randomX, randomY, 0);
            GameObject pipe = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

            // Parent to pipesParent if assigned
            if (pipesParent != null)
                pipe.transform.parent = pipesParent;

            timer = 0f;
        }
    }
}
