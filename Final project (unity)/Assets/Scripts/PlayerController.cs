using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;

    public float moveSpeed;
    public float lerpSpeed;

    Rigidbody2D rb;
    Vector2 velocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        LerpMove();
    }

    void LerpMove()
    {
        if (Input.GetKey(upKey))
        {
            velocity = Vector2.Lerp(velocity, Vector2.up, lerpSpeed);
        }
        else if (Input.GetKey(downKey))
        {
            velocity = Vector2.Lerp(velocity, Vector2.down, lerpSpeed);
        }
        else if (Input.GetKey(leftKey))
        {
            velocity = Vector2.Lerp(velocity, Vector2.left, lerpSpeed);
        }
        else if (Input.GetKey(rightKey))
        {
            velocity = Vector2.Lerp(velocity, Vector2.right, lerpSpeed);
        }
        else
        {
            velocity = Vector2.Lerp(velocity, Vector2.zero, lerpSpeed);
        }

        Vector2 newPos = rb.position + velocity * moveSpeed * Time.deltaTime; // position + velocity * moveSpeed
        rb.MovePosition(newPos);
    }
}
