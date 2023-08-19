using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldermovement : MonoBehaviour
{
    public bool isDragging = false;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the left mouse button is pressed down
        if (Input.GetMouseButtonDown(0))
        {
            
           isDragging = true;
           offset = gameObject.transform.position - GetMouseWorldPosition();
                
            
        }

        // Check if the left mouse button is released
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        // If isDragging is true, move the object to the current mouse position with the offset applied
        if (isDragging)
        {
            gameObject.transform.position = GetMouseWorldPosition() + offset;
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
