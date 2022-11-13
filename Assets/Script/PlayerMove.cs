using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody2D rb;


    Vector3 moveDirection;
    public float moveSpeed;

    public InputComponent input;

    public LockCheck currentLock;


    private void Start()
    {
        input = GetComponent<InputComponent>();
    }


    private void FixedUpdate()
    {
        GetInput();
        Move();
    }


    public void GetInput()
    {
        var inputx = Input.GetAxisRaw("Horizontal");
        var inputy = Input.GetAxisRaw("Vertical");
        //moveDirection = new Vector3(inputx, inputy, 0);
        moveDirection = input.dirInput;
    }

    public void Move()
    {
        rb.velocity = moveDirection.normalized * moveSpeed;
    }

    public void Move(Vector2 input)
    {
        moveDirection = new Vector3(input.x, input.y, 0);
        rb.velocity = moveDirection.normalized * moveSpeed;
    }

    public void ReceiveVertical(float value)
    {
        moveDirection = new Vector3(value, moveDirection.y, 0);
        Debug.Log("player receive vertical val" + moveDirection.y);
    }

    public void ReceiveHorizontal(float value)
    {
        moveDirection = new Vector3(moveDirection.x, value, 0);
        Debug.Log("player receive vertical val" + moveDirection.x);
    }

    public void SetCurrentLock(LockCheck newLock)
    {
        currentLock = newLock;
    }

    public void UseKey()
    {

        var playerlist = GameCore.gamecore.itemsystem.playerItems;
        var id = playerlist[GameCore.gamecore.backPack.SelecIndex].Id;
        currentLock.CheckKey(id);
    }

}
