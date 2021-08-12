using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rigidBody;
    public Camera cameraPosition;
    
    //Vector2 has a x and a y, kind of "propreties", which you can mess around, just like in the code below
    private Vector2 movement;
    public Vector2 mousePosition;

    void Update()
    {
        //Setting the x and y to 1 or -1 based on input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePosition = cameraPosition.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDirection = mousePosition - rigidBody.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 45f;

        rigidBody.rotation = angle;

    }
}
