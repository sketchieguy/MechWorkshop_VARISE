using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topleft : MonoBehaviour
{
    public Animator object4animator;

    public bool animator3 = false;


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.CompareTag("cuts4"))
                {
                    object4animator.SetTrigger("DestroyTrigger");
                    Debug.Log("topleft");
                    StartCoroutine(waitforseconds());
                   animator3 = true;

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
