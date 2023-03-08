using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private Player p;
    
    public float health = 10f;

    private void Awake(){
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")){
            p.HealSelf(health);
            Destroy(gameObject);
        }
    }
}
