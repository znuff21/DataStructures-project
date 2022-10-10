using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInventory : MonoBehaviour
{
   
    DoubleLinkedList inventoryQueue = new DoubleLinkedList();
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Items"){
            Debug.Log("Item picked");
            inventoryQueue.push(other.gameObject);
            Destroy(other.gameObject, 0.5f);
             }
}
    void OnInventory(InputValue value){
        if(value.isPressed){
            Debug.Log("Number of items: " + inventoryQueue.Count());
        }
    }

}

public class DoubleLinkedList
{ 
	public Node head;
    int lenght;

	public class Node {
		public GameObject data;
		public Node prev;
		public Node next;

		public Node(GameObject d) { data = d; }
	}

	
	public void push(GameObject new_data)
	{
		
		Node new_Node = new Node(new_data);

		lenght++;
		new_Node.next = head;
		new_Node.prev = null;

	
		if (head != null)
			head.prev = new_Node;

		head = new_Node;
	}


	public void InsertAfter(Node prev_Node, GameObject new_data)
	{

		if (prev_Node == null) {
			Debug.Log(
				"The given previous node cannot be NULL ");
			return;
		}
		Node new_node = new Node(new_data);
		new_node.next = prev_Node.next;
		prev_Node.next = new_node;
		new_node.prev = prev_Node;
        lenght++;

		
		if (new_node.next != null)
			new_node.next.prev = new_node;
            lenght++;
	}

	
	void append(GameObject new_data)
	{
		
		Node new_node = new Node(new_data);

		Node last = head; 

		
		new_node.next = null;

		
		if (head == null) {
			new_node.prev = null;
			head = new_node;
			return;
		}

		
		while (last.next != null)
			last = last.next;

		
		last.next = new_node;

		
		new_node.prev = last;
	}

	
	public int Count()
	{
		return lenght;
	}

	
}