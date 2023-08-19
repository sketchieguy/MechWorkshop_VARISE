using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomright : MonoBehaviour
{
    public Animator object2animator;

    public bool animator2 = false;


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.CompareTag("cuts2"))
                {
                    object2animator.SetTrigger("DestroyTrigger");
                    Debug.Log("bottomright");
                    StartCoroutine(waitforseconds());
                    animator2 = true;

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
