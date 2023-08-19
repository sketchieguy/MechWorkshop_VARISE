using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottom : MonoBehaviour
{
    public Animator object6animator;
    public bottomright bottomRight;
    public bottomleft bottomLeft;
    public topleft topLeft;
    public topright topRight;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (bottomRight.animator2 == true && bottomLeft.animator1 == true && topRight.animator4 == true && topLeft.animator3 == true)
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (hit.collider.CompareTag("cuts7"))
                    {
                        if ((object6animator != null))
                        {
                            object6animator.SetTrigger("DestroyTrigger");



                        }

                    }
                }

            }
        }
       

       
       
    }
}
