using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    private Text CounterTXT;
    public int amount;

    public void Awake(){
        CounterTXT = GetComponent<Text>();
    }

    public void LateUpdate(){
        CounterTXT.text = amount.ToString("0000");
    }
}
