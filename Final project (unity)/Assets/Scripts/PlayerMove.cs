using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
        private Rigidbody2D rb;
        public float speed;
        Vector2 movement;

        public KeyCode leftKey;
        public KeyCode rightKey;
        public KeyCode upKey;
        public KeyCode downKey;

    //public Transform groundPos;  //feetpos
        //private bool isGrounded;
        //public float checkRadius;
        //public LayerMask whatIsGround;

     
        //Animator animator;


        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
           //animator = GetComponent<Animator>();
        }

        void FixedUpdate() //!
        {
          
            Vector2 velocity = rb.velocity;
          
            rb.velocity = new Vector2(movement.x * speed, movement.y * speed);  //wont lerp
    }

        // Update is called once per frame
        void Update()
        {
            // left and right movement
            movement = Vector2.zero;

            if (Input.GetKey(rightKey))
            {
                movement += Vector2.right;
            }

            if (Input.GetKey(leftKey))
            {
                movement += Vector2.left;
            }
            if (Input.GetKey(upKey))
            {
                movement += Vector2.up;
            }

            if (Input.GetKey(downKey))
            {
                movement += Vector2.down;
            }


        if (movement.x == 0)   //for animation just check the teacher sample
            {
                //animator.SetBool("isIDLE", true);
            }

            if (movement.x > 0)
            {
                transform.eulerAngles = new Vector3(0, 0, 90);
            }
            else if (movement.x < 0)
            {
                transform.eulerAngles = new Vector3(0, 0, -90);
            }
            if (movement.y > 0)
            {
                transform.eulerAngles = new Vector3(0, 0, 170);
            }
            else if (movement.y < 0)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }

    }
    }
