using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformA : MonoBehaviour
{


void Update() 
  {
      
   if (Input.GetKeyDown(KeyCode.B)) {
   GetComponent<SpriteRenderer>().enabled = false;
   GetComponent<Collider2D>().enabled = false;

   }
   if (Input.GetKeyDown(KeyCode.V)) {
    GetComponent<SpriteRenderer>().enabled = true;
   GetComponent<Collider2D>().enabled = true;
   }
 }
}
