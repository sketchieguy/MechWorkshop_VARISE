using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topright : MonoBehaviour
{
    public Animator object3animator;

    public bool animator4 = false;

    
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.CompareTag("cuts3"))
                {
                    object3animator.SetTrigger("DestroyTrigger");
                    Debug.Log("topright");
                    StartCoroutine(waitforseconds());
                   animator4 = true;

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
