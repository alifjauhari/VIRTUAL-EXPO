﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomugm : MonoBehaviour
{

    public GameObject trigger;
 
 void Start () {
         trigger.SetActive (false);
     }
 
 void OnTriggerEnter(Collider _col){
         if (_col.gameObject.CompareTag ("UGM")) {
             trigger.SetActive (true);
                 }
         }

         void OnTriggerExit(Collider _col){
         if (_col.gameObject.CompareTag ("UGM")) {
             trigger.SetActive (false);
         }
     }
}
