using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;


    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Debug.Log(rb.position + "Start");
    }

    void Update()
    {
        Debug.Log(rb.position + "BeforeVector");
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Debug.Log(rb.position + "Vector2");       
        moveVelocity = moveInput.normalized * speed;
        Debug.Log(rb.position + "moveVelocity");
    }

    void FixedUpdate()
    {
//      rb.MovePosition(rb.position = moveVelocity * Time.fixedDeltaTime);
        rb.velocity = moveVelocity;
        Debug.Log(rb.position + "MovePosition");
    }
}
