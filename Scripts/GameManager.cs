using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player p;

    public Bar hpFill;
    public Bar xpFill;
    public Counter killsTXT;
    public Counter scoreTXT;

    [HideInInspector] public int kills = 0;
    [HideInInspector] public float score = 0;

    [HideInInspector] public GameObject weapon;

    void Start(){
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        weapon = GameObject.FindGameObjectWithTag("Weapon");
        hpFill.maxValue = p.health;
    }

    void LateUpdate(){
        hpFill.currentValue = p.health;
        killsTXT.amount = kills;
        scoreTXT.amount = Mathf.RoundToInt(score);
    }

    public void AddKill(){
        kills++;
    }

    public void AddScore(float amount){
        score += amount;
    }

    public void GameOver(){
        weapon.SetActive(false);
        Time.timeScale = 0f;
    }
}
