using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;

    void Start(){
        Destroy(gameObject, lifeTime);
    }

    void Update(){
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
