using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnsolder : MonoBehaviour
{
    public GameObject prefabtospawn;
    private GameObject spawnedprefab;
    

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            spawnprefab();
        } 
       else if (Input.GetMouseButtonUp(0))
        {
            destroyspawnedprefab();
        }
    }
    void spawnprefab()
    {
        if (prefabtospawn != null && spawnedprefab ==null) 
        {
            spawnedprefab = Instantiate(prefabtospawn, transform.position, transform.rotation);
        }
    }
    void destroyspawnedprefab()
    {
        if (spawnedprefab != null )
        {
            Destroy(spawnedprefab);
            spawnedprefab = null;
        }
    }
}
