using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class wirelength : MonoBehaviour
{
    public float decreasespeed = 0.01f;
    public float minlength = 0.1f;
    private bool iscolliding = false;
    private float originalscaleY;
    // Start is called before the first frame update
    void Start()
    {
        //recording the original scale of the wire along the y axis 
        originalscaleY = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (iscolliding && transform.localScale.y > minlength)
        {
            float newscaleY = transform.localScale.y - decreasespeed * Time.deltaTime;
            // clamping the length to th eminimum value 
            newscaleY = Mathf.Max(newscaleY, minlength);
            //updating the wires scale with the new length 
            transform.localScale = new Vector3(transform.localScale.x , newscaleY , transform.localScale.z);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        iscolliding = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        iscolliding = false; 
    }
}
