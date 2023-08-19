using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public float rotationSpeed = 1f; // Adjust this to control the speed of rotation
    public float radius = 0.8f;      // The radius of the circular boundary

    private Vector3 lastPosition;   // Stores the camera's last known position


    void Start()
    {
        lastPosition = transform.position; 
    }

   
    void Update()
    {
       if (Input.GetKey(KeyCode.LeftShift))
        {
            // Check if the horizontal or vertical arrow keys or WASD  are pressed
            bool isVerticalPressed = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);
            bool isHorizontalPressed = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S);

            // Calculate the new position based on input
            if (isHorizontalPressed || isVerticalPressed)
            {
                float verticalInput = isVerticalPressed ? Input.GetAxis("Horizontal") : 0f;
                float horizontalInput = isHorizontalPressed ? Input.GetAxis("Vertical") : 0f;

                float angle = Mathf.Atan2(verticalInput, horizontalInput);
                float distance = Mathf.Clamp(Mathf.Sqrt(horizontalInput * horizontalInput + verticalInput * verticalInput), 0f, 1f);
                float circularRadius = distance * radius;

                // Calculate the new position in the Y-Z plane
                float x = 0f;
                float y = Mathf.Cos(angle) * circularRadius;
                float z = Mathf.Sin(angle) * circularRadius;

                // Update the camera's position
                transform.position = new Vector3(x, y, z);

                // Update the lastPosition with the new position
                lastPosition = transform.position;
            }
            else
            {
                // If no arrow keys are pressed, keep the camera at its last known position
                transform.position = lastPosition;
            }
        }
    }
}
