using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelTrigger : MonoBehaviour
{
    Queue<int> enemyQueue = new Queue<int>();
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
        enemyQueue.Dequeue();
        Debug.Log("Enemy killed");
    }
    void NextLevel(Queue<int> enemyQueue){
        
        if(enemyQueue.Count == 0 && cdt == 0){
            Debug.Log("Next level");
            cdt++;
        }
    }
}
