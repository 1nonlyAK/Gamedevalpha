using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float speed = 4.0f;
    Rigidbody2D rb; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
   
    void Update()
    {
     horizontal= Input.GetAxisRaw("Horizontal");
     vertical= Input.GetAxisRaw("Vertical");
     rb.velocity = new Vector2(horizontal*speed,vertical*speed);
    }
}
