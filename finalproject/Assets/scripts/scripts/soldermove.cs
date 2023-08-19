using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldermove : MonoBehaviour
{
    public float scrollSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        Vector3 movement = new Vector3(scrollInput, 0.0f, 0.0f) * scrollSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
