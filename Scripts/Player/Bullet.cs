using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public Player Player;

    void Start(){
        Destroy(gameObject, lifeTime);
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    void Update(){
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Enemy")){
            Enemy Enemy = other.gameObject.GetComponent<Enemy>();
            
            Enemy.TakeDamage(Player.damage);
            Destroy(gameObject);
        } 
    }
}
