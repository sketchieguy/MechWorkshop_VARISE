using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class patchspawn : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
           if (Input.GetMouseButtonDown(0))
            {

            }
        }

    }


}
