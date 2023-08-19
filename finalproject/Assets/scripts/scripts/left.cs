using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left : MonoBehaviour
{
    public Animator object7animator;
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
                    if (hit.collider.CompareTag("cuts8"))
                    {
                        if ((object7animator != null))
                        {
                            object7animator.SetTrigger("DestroyTrigger");


                        }

                    }
                }

            }
        }
         
        
    }
}
