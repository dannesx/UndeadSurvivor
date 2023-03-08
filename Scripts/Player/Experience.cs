using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience : MonoBehaviour
{
    public float currentXP;
    public float maxXP = 100;
    public float increaseRate = 20;
    public int level = 1;

    public void Update(){
        if(currentXP >= maxXP){
            level++;
            currentXP = 0;
            maxXP += increaseRate;
        }
    }

    public void AddXP(float amount){
        currentXP += amount;
    }
}
