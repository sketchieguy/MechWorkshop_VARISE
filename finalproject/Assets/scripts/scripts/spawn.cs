using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject prefabToSpawn;
   

    private void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from this GameObject in the forward direction
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            // Visualize the ray
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red);

            // Check if the ray hits an object with the specified tag
            if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("plate"))
            {
                // Spawn the prefab at the point of collision
                Instantiate(prefabToSpawn, hit.point, Quaternion.identity);
            }
        }
    }
}
