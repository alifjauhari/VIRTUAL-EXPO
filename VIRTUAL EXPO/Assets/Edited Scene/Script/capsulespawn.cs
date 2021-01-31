using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsulespawn : MonoBehaviour
{

    public GameObject trigger;
 
 void Start () {
         trigger.SetActive (false);
     }
 
 void OnTriggerEnter(Collider _col){
         if (_col.gameObject.CompareTag ("ITB")) {
             trigger.SetActive (true);
                 }
         }

         void OnTriggerExit(Collider _col){
         if (_col.gameObject.CompareTag ("ITB")) {
             trigger.SetActive (false);
         }
     }
}
