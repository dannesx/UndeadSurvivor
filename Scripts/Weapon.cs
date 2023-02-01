using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    SpriteRenderer sprite;
    public GameObject bullet;
    public Transform spawnPoint;

    void Awake(){
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update(){
        Aim();
        Shoot();
    }

    void Aim(){
        Vector3 mouse = Input.mousePosition;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        Vector2 offset = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);
        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        FlipSprite(mouse, screenPoint, angle);
    }

    void FlipSprite(Vector3 mouse, Vector3 screenPoint, float angle){
        transform.rotation = Quaternion.Euler(0, 0, angle);
        sprite.flipY = mouse.x < screenPoint.x;
    }

    void Shoot(){
        if(Input.GetButtonDown("Fire1")){
            Instantiate(bullet, spawnPoint.position, transform.rotation);
        }
    }
}
