using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public float speed;
    public float attackSpeed;
    public float damage;
    public float points;
    public bool isAlive = true;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    private Collider2D col;
    private Player player;

    [HideInInspector] public Rigidbody2D target;
    [HideInInspector] public GameManager GM;

    public void Start(){
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        col = GetComponent<Collider2D>();
        
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    public void FixedUpdate(){
        if(target != null && isAlive){
            Vector2 direction = target.position - rb.position;
            Vector2 movement = direction.normalized * speed * Time.fixedDeltaTime;

            rb.MovePosition(rb.position + movement);
            rb.velocity = Vector2.zero;
        }
    }

    public void LateUpdate(){
        if(isAlive) sprite.flipX = target.position.x < transform.position.x;
    }

    public void Attack(){
        player.TakeDamage(damage);
        Debug.Log("Attack! HP: " + player.health);
    }

    public void TakeDamage(float amount){
        health -= amount;

        if(health <= 0){
            Death();
        } else {
            anim.SetTrigger("Hit");
        }
    }

    public void Death(){
        isAlive = false;
        col.enabled = false;
        sprite.sortingOrder = 0;
        anim.SetBool("Dead", true);
        GM.AddKill();
        GM.AddScore(points);
        Destroy(this.gameObject, 1f);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")) Attack();
    }
}
