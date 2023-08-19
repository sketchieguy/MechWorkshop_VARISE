using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stick : MonoBehaviour
{
    public Transform objectToStickTo; // Assign the other object in the Inspector

    private Vector3 offset;

    void Start()
    {
        // Calculate the initial offset between the two objects
        offset = transform.position - objectToStickTo.position;
    }

    void Update()
    {
        // Update the position of the object based on the position of the objectToStickTo and the initial offset
        transform.position = objectToStickTo.position + offset;
    }
}
