using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool isAlive = true;
    public NextLevelTrigger nextLevelTrigger;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player" && isAlive == true){
            isAlive = false;
            nextLevelTrigger = FindObjectOfType<NextLevelTrigger>();
            nextLevelTrigger.DequeueEnemy();

        }
    }

}
