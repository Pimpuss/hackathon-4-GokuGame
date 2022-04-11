using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public GameObject objectToDestroy;

   private void OnTriggerEnter2D(Collider2D collision) 
   {
       if(collision.CompareTag("Player"))
       {        
            Inventory.instance.AddChicken(1);
            Destroy(objectToDestroy);
       } 

   }
}
