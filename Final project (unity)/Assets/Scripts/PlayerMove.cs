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

    AudioSource audio;
    //Animator animator;


    // Start is called before the first frame update
    void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
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
                //audio.Stop();
        }

            if (movement.x > 0)
            {
                transform.eulerAngles = new Vector3(0, 0, 90);
                //audio.Play();
        }
            else if (movement.x < 0)
            {
                transform.eulerAngles = new Vector3(0, 0, -90);
                //audio.Play();
        }
            if (movement.y > 0)
            {
                transform.eulerAngles = new Vector3(0, 0, 170);
                //audio.Play();
        }
            else if (movement.y < 0)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                //audio.Play();
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("items"))
        {
            audio.Play();
        }
    }
}
