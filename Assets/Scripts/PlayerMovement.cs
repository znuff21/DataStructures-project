using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Vector2 moveInput;
    Rigidbody2D myRigidBody;
    Vector2 playerVelocity;
    Vector2 gravity;
    [SerializeField] float moveSpeed = 5;
    [SerializeField] float jumpSpeed = 10;
    Sprite Character;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        Character = GetComponent<Sprite>();
    }

    void Update()
    {
        Run();
        
    }
    void OnMove(InputValue value){
        moveInput = value.Get<Vector2>();
        

    }
    void OnJump(InputValue value){
        if(value.isPressed){
            myRigidBody.velocity += new Vector2(0f, jumpSpeed);
        }
    }
    void Run(){
        
        playerVelocity = new Vector2(moveInput.x * moveSpeed , myRigidBody.velocity.y );
        myRigidBody.velocity = playerVelocity;
    }
}
