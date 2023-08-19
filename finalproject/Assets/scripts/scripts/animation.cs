using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    // Store the Animator components for each object with their animations
    public Animator object1Animator;
    public Animator object2Animator;
    public Animator object3Animator;
    public Animator object4Animator;

    // Update is called once per frame
    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the mouse pointer
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits an object
            if (Physics.Raycast(ray, out hit))
            {
                // Check which object is hit and trigger its animation
                if (hit.collider.CompareTag("cuts1"))
                {
                    TriggerAnimation(object1Animator);
                    Debug.Log("this worked ");
                }
                else if (hit.collider.CompareTag("cuts2"))
                {
                    TriggerAnimation(object2Animator);
                    Debug.Log("this worked ");
                }
                else if (hit.collider.CompareTag("cuts3"))
                {
                    TriggerAnimation(object3Animator);
                    Debug.Log("this worked ");
                }
                else if (hit.collider.CompareTag("cuts4"))
                {
                    TriggerAnimation(object4Animator);
                    Debug.Log("this worked ");
                }
            }
        }
    }

    // Trigger the animation on the specified Animator component
    void TriggerAnimation(Animator animator)
    {
        if (animator != null)
        {
            animator.SetTrigger("DestroyTrigger"); // Assuming the trigger parameter name is "DestroyTrigger"
        }
    }
}
