using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class spawnAtTip : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public GameObject parentPrefab;
    private Vector3 banKai;
    private bool drag=false;
    Vector3 mousePosition;

    bool snapped = false;                       //second set
    GameObject snapparent;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //banKai = this.gameObject.transform.GetChild(1).transform.position;
    }

    /*private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }
    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();

    }*/
    

    // Update is called once per frame
    void Update()
    {
        banKai = this.gameObject.transform.GetChild(1).transform.position;
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefabToSpawn, banKai, Quaternion.identity ,parentPrefab.transform);
            drag = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            drag = false;
        }
    }

    void OnTriggerStay(Collider collider)
    {

        if (collider.gameObject.tag == "plate" || collider.gameObject.tag == "cuts5" || collider.gameObject.tag == "cuts6" || collider.gameObject.tag == "cuts7" || collider.gameObject.tag == "cuts8")
        {
            snapped = true;
            snapparent = collider.gameObject;
            offset = transform.position - snapparent.transform.position;
            
        }
        if (collider.gameObject.tag == "Test")
        {
            Instantiate(prefabToSpawn, banKai, Quaternion.identity);
            Debug.Log("lol");
        }
    }
    
    
}
