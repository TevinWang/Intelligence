 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 
 public class speed : MonoBehaviour {

     public GameObject speedText;
     

     void Update () {
         var speed = GetComponent<Rigidbody>().velocity.magnitude;
        TextMesh textObject = speedText.GetComponent<TextMesh>();
        textObject.text = "speed:" + GetComponent<Rigidbody>().velocity.magnitude + "m/s";
         Debug.Log("speed:" + GetComponent<Rigidbody>().velocity.magnitude + "m/s"); 
     }
 }
 