using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    //private GameObject startObject;
    public GameObject startObject;
    // Start is called before the first frame update
    void Start()
    {
       startObject = GameObject.FindGameObjectWithTag("Start");
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider whatHitMe)
    {
        if(whatHitMe.tag == "Player")
        {
            whatHitMe.transform.position = startObject.transform.position;
            //Debug.Log("Something hit me");
        }
        
    }
}

