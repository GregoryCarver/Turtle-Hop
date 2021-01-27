using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script controls the turtle's hop strength. 
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D turtle;
    public bool isGrounded;
    bool hasJumped;
    float jumpStrength;
    Animator turtleAnimator;
    public AudioSource jumpSound;
    public AudioSource jumpPrepSound;

    private void Start()
    {
        turtleAnimator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update ()
    {
        if(turtle.IsTouchingLayers())
        {
            if(hasJumped)
            {
                turtleAnimator.SetBool("Landing", true);
                turtleAnimator.SetBool("InJumpPrep", false);
                turtleAnimator.SetBool("Jumping", false);
            }

            isGrounded = true;
            hasJumped = false;
        }
        if (!turtle.IsTouchingLayers())
        {
            isGrounded = false;
            hasJumped = true;
        }

        //Build jump strength when you hold space down.

        if(Input.GetMouseButtonDown(0))
        {
            jumpPrepSound.Play();
        }

        if (Input.GetMouseButton(0) && isGrounded)
        {
            jumpStrength += Time.deltaTime * 377;
            turtleAnimator.SetBool("InJumpPrep", true);
            turtleAnimator.SetBool("Landing", false);
            if (jumpStrength > 350)
            {
                jumpStrength = 350;
            }
        }
        //Initiate jump when you let go of space.
        if (Input.GetMouseButtonUp(0))
        {
            turtle.AddForce(transform.up * jumpStrength + transform.right * jumpStrength / 2);
            jumpSound.Play();
            jumpStrength = 0;
            turtleAnimator.SetBool("Jumping", true);
        }
    }
}
