using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmousecase : MonoBehaviour
{
    public float sensitivity = 10.0f; // Mouse sensitivity for object movement
    public float clampValue = 5.0f; // Clamping the object's position
    private Vector3 initialPosition;
    private void Start()
    {
        initialPosition = new Vector3(-1.512f, -0.134f, -0.488f);
        transform.position = initialPosition;
        transform.position = initialPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the mouse movement in the X and Y axes
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Get the scroll wheel input
        float scrollWheel = Input.GetAxis("Mouse ScrollWheel");

        // Calculate the new position for the object
        Vector3 newPosition = transform.position;
        newPosition.x += mouseY * sensitivity * Time.deltaTime;
        newPosition.z += mouseX * sensitivity * Time.deltaTime * -1;
        newPosition.y += scrollWheel * sensitivity * Time.deltaTime;

        // Clamp the position to a certain range
        newPosition.x = Mathf.Clamp(newPosition.x, -clampValue, clampValue);
        newPosition.z = Mathf.Clamp(newPosition.z, -clampValue, clampValue);
        newPosition.y = Mathf.Clamp(newPosition.y, -clampValue, clampValue);

        // Update the object's position
        transform.position = newPosition;
    }
}
