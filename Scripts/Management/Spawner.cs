using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Transform[] spawnPoints;
    public GameObject[] objects;
    public float spawnRate;
    
    private float timer = 0;

    private void Awake(){
        spawnPoints = GetComponentsInChildren<Transform>();
    }

    private void Start(){
        Spawn();
    }

    private void Update(){
        timer += Time.deltaTime;

        if(timer > spawnRate){
            timer = 0;
            Spawn();
        }
    }

    private void Spawn(){
        GameObject prefab = objects[Random.Range(0, objects.Length)];
        Transform randomPoint = spawnPoints[Random.Range(1, spawnPoints.Length)];

        Instantiate(prefab, randomPoint.position, Quaternion.identity);
    }
}