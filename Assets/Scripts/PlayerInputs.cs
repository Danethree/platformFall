using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    private float horizontal;
    private Vector2 newMovement;
    private Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
      playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        InputMovement();
       
    }
     void FixedUpdate()
    {
        playerRb.velocity = newMovement;
      
    }

    void InputMovement()
    {
          horizontal = Input.GetAxisRaw("Horizontal");
          Movement(horizontal);
         
    }
    void Movement(float direction)
    {
          float speed = 5;
          newMovement = new Vector2(direction *speed,playerRb.velocity.y);

    }

}
