
using UnityEngine;

public class soldercontrol : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private bool isDragging = false;

    void Start()
    {
        Vector3 initialRotation = new Vector3(90f, 0f, 0f);
        Quaternion targetRotation = Quaternion.Euler(initialRotation);
        transform.rotation = targetRotation;
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // When the left mouse button is pressed down, start dragging the object
            isDragging = true;

            // Store the initial position of the object and the mouse cursor
            screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            offset = transform.position - GetMouseWorldPosition();
        }

        if (Input.GetMouseButtonUp(0))
        {
            // When the left mouse button is released, stop dragging the object
            isDragging = false;
        }

        if (isDragging)
        {
            // While dragging, update the position of the object based on the mouse movement
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) ;

            transform.position = curPosition;
        }
        if (!isDragging)
        {
            // Rotate the object based on mouse movement (you can modify this as needed)
            float rotationSpeed = 500f;
            float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float rotationY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, -rotationX, Space.World);
            transform.Rotate(Vector3.right, rotationY, Space.World);
        }
    }

    Vector3 GetMouseWorldPosition()
    {
        // Get the mouse position in screen coordinates and convert it to world coordinates
        Vector3 mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mouseScreenPosition);
    }
}
