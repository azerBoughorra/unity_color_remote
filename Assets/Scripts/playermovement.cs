using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Animator anim;
    public float speed;
    
    Rigidbody2D rb;
    public int movementspeed;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        HandleMovement(horizontal);
        
    }
    void HandleMovement(float horizonal)
    {
        //CARACTER MOVEMENT
  
        rb.velocity = new Vector2(horizonal * movementspeed, rb.velocity.y);
        if (horizonal != 0)
        {
            if (horizonal < 0)
            {
                transform.localScale = new Vector2(-1,1);
            }
            else
            {
                transform.localScale = new Vector2(1,1);
            }
                
            
        }
       if(Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("walk", true);
        }
       else
        anim.SetBool("walk", false);
    }
}