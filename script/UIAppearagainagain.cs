﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIAppearagainagain : MonoBehaviour
{


    [SerializeField] private Image customImage;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            customImage.enabled = true;





        }

    }
}
