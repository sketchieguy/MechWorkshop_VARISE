using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomleft : MonoBehaviour
{
    public Animator object1animator;

    public bool animator1 = false;
    void Update()
    {   
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) )
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.CompareTag("cuts1"))
                {
                    if ((object1animator != null))
                    {
                        object1animator.SetTrigger("DestroyTrigger");
                        Debug.Log("bottomleft");
                        StartCoroutine(waitforseconds());
                        animator1 = true;
                    }

                }
            }
            
        }
        IEnumerator waitforseconds()
        {
            yield return new WaitForSeconds(3);
            Destroy(gameObject);

        }
    }
}
