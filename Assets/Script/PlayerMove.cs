using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody2D rb;


     Vector3 moveDirection;
    public float moveSpeed;

    private void FixedUpdate()
    {
        GetInput();
        Move();
    }


    public void GetInput()
    {
        var inputx = Input.GetAxisRaw("Horizontal");
        var inputy = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(inputx, inputy, 0);

    }

    public void Move()
    {
        rb.velocity = moveDirection.normalized * moveSpeed;
    }




}
