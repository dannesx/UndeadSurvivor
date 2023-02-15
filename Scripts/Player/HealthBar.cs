using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Player player;

    public Image healthBar;
    public float maxHealth;

    public void Start(){
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        maxHealth = player.health;
    }

    public void LateUpdate(){
        healthBar.fillAmount = player.health / maxHealth;
    }
}
