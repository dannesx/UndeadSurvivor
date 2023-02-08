using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [HideInInspector]
    public Transform player;

    public int health;
    public float speed;
    public float attackSpeed;
    public float damage;

    public void Start(){
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Damage(){}

    public void TakeDamage(int amount){
        health -= amount;

        if(health <= 0){
            Destroy(this.gameObject);
        }
    }
}
