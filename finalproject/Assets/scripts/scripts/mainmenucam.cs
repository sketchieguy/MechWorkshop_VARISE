using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenucam : MonoBehaviour
{
    public float circleRadius = 85f;
    public float movementSpeed = 5f;
    public Transform target; // The target (origin) to focus on

    private float angle = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the position on the circle using polar coordinates
        float x = circleRadius * Mathf.Cos(angle * Mathf.Deg2Rad);
        float z = circleRadius * Mathf.Sin(angle * Mathf.Deg2Rad);

        // Set the camera's position
        transform.position = new Vector3(x, transform.position.y, z);

        // Look at the target (origin) to keep the camera focused on it
        transform.LookAt(target);

        // Increase the angle for the next frame to move the camera along the circle
        angle += movementSpeed * Time.deltaTime;

        // Wrap the angle around 360 degrees to keep it within a full circle
        angle %= 360f;
    }
}
