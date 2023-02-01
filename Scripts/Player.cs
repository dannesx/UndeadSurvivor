using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private SpriteRenderer sprite;
    private Animator anim;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update(){
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Speed", moveInput.magnitude);
    }

    void FixedUpdate(){
        Vector2 movement = moveInput.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }

    void LateUpdate(){
        Vector3 mouse = Input.mousePosition;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        sprite.flipX = mouse.x < screenPoint.x;
    }
}