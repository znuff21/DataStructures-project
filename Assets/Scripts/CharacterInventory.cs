using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInventory : MonoBehaviour
{
   
    LinkedList <GameObject> inventoryQueue = new LinkedList <GameObject>();
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Items"){
            Debug.Log("Item picked");
            inventoryQueue.AddFirst(other.gameObject);
            Destroy(other.gameObject, 0.5f);
             }
}
    void OnInventory(InputValue value){
        if(value.isPressed){
            Debug.Log("Number of items: " + inventoryQueue.Count);
        }
    }

}
