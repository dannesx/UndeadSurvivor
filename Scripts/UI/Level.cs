using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    private Text LevelTXT;
    private Experience p;

    private void Awake(){
        LevelTXT = GetComponent<Text>();
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Experience>();
    }

    public void LateUpdate(){
        LevelTXT.text = "Lv. " + p.level.ToString("00");
    }
}
