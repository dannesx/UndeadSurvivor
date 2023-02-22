using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public float maxValue;
    public float currentValue;

    void Update(){
        transform.localScale = new Vector3(currentValue / maxValue, 1f, 1f);
    }
}
