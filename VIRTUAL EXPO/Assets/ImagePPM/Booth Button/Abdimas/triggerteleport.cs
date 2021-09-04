using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerteleport : MonoBehaviour
{

    public GameObject trigger;
 
 void Start () {
         trigger.SetActive (false);
     }
 


         void OnTriggerExit(Collider _col){
         if (_col.gameObject.CompareTag ("teleport")) {
             trigger.SetActive (false);
         }
     }
}
