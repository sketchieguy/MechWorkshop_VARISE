using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerarotate : MonoBehaviour
{
    public float sensitivity = 2.0f;
    public float minXRotation = -90.0f; 
    public float maxXRotation = 90.0f; 

    private float rotationX = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        
        transform.Rotate(0, mouseX, 0);

        
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, minXRotation, maxXRotation);

        
        transform.localRotation = Quaternion.Euler(rotationX, transform.localEulerAngles.y, 0);
    }
}
