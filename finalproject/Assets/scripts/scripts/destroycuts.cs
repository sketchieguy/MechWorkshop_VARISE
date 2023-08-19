using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroycuts : MonoBehaviour
{
    public Animator object1Animator;
    public Animator object2Animator;
    public Animator object3Animator;
    public Animator object4Animator;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) )
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.CompareTag("cuts1"))
                {
                    
                }
            }
        }
    }
}

