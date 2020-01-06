using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationTriggerS : MonoBehaviour
{
    public GameObject exit;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider whatHitMe)
    {
        if (whatHitMe.tag == "Player")
        {
            exit.gameObject.SetActive(true);
            exit.GetComponent<Animator>().Play("endAnimation");
        }

    }
}
