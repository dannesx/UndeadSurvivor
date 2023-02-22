using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    public Text timerTXT;

    private float minutes;
    private float seconds;

    public void FixedUpdate(){
        time += Time.fixedDeltaTime;
        minutes = Mathf.FloorToInt(time / 60);
        seconds = Mathf.FloorToInt(time % 60);
    }

    public void LateUpdate(){
        timerTXT.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
