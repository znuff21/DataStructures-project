using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelTrigger : MonoBehaviour
{
    PQueue enemyQueue = new PQueue();
    int cdt = 0;
    void Start()
    {
        enemyQueue.Enqueue(1);
        enemyQueue.Enqueue(2);
        enemyQueue.Enqueue(3);
    }
    void Update()
    {
        NextLevel(enemyQueue);
    }
    public void DequeueEnemy(){
        enemyQueue.DeQueue();
        Debug.Log("Enemy killed");
    }
    void NextLevel(PQueue enemyQueue){
        
        if(enemyQueue.IsEmpty() == true && cdt == 0){
            Debug.Log("Next level");
            cdt++;
        }
    }
}

public class PQueue
{
    public Node head;
    int lenght;

	public class Node {
		public int data;
		public Node prev;
		public Node next;

		public Node(int d) { data = d; }
	}
  Node front;
  Node rear;
  
  public PQueue()
  {
    front = null;
    rear = null;
  }
        public Node GetNode(int data)
        {
              Node node = new Node(data);
              return node;
        }
    public void Enqueue(int data)
 {
    Node newNode = GetNode(data);
     if (front == null)
     {
         front = rear = newNode;
         return;
     }
     rear.next = newNode;
     rear = newNode;
 }
public void DeQueue()
{
    int peek = -1;
    if (front != null)
    {
        peek = front.data;
        front = front.next;
    }
    
}
public bool IsEmpty()
        {
            if(front==null)
            {
                return true;
            }
            return false;
        }
}
