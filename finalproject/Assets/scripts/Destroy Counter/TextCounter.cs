using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCounter : MonoBehaviour
{

    public GameObject a;
    // Start is called before the first frame update
    public static int destroyCounter=0;
    public GameObject Counter;

    // Update is called once per frame
    void Update()
    {
        /*if (a.GetComponent<Animator>().Play("bottomleft") == true)
        {
            destroyCounter++;
            Counter.GetComponent<TMPro.TextMeshProUGUI>().text = "" + destroyCounter;
        }*/
    }
    
    
    private void OnTriggerStay(Collision )
    {

    }
}
