using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WholeChicken : MonoBehaviour
{
    public GameObject objectToDestroy;

   private void OnTriggerEnter2D(Collider2D collision) 
   {
       if(collision.CompareTag("Player"))
       {        
            Inventory.instance.AddChicken(50);
            Destroy(objectToDestroy);
       } 

   }
}
