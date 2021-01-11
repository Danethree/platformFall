using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
  
    Rigidbody2D platformRb;
   
   void Start()
   {
       platformRb = GetComponent<Rigidbody2D>();
   }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
             Invoke("Fall",0.5f);
        }
       
   
    }
    void Fall()
    {
        platformRb.gravityScale = 1;
    }
}
