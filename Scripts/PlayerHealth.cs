using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[Unity3d Episode 5] Knockback, Health and Damage, by TheSenpaiCode (
//https://www.youtube.com/watch?v=lGUPG7smpXo)
//full script used and adapted to my game

//How to make a HEALTH BAR in Unity!, by 
//Brackeys(https://www.youtube.com/watch?v=BLfNP4Sc_iA)
//full script used and adapted to my game


public class PlayerHealth : MonoBehaviour
{

    public int maxHealth;
    public int currentHealth;
    public PlayerController theplayer;



   public HealthBar healthBar; 

    void Start()
    {

        currentHealth = maxHealth;

        theplayer = FindObjectOfType<PlayerController>();

        healthBar.SetMaxHealth(maxHealth);

    }

    void Update()
    {
        

    }

    public void DamagePlayer(int Hurt, Vector3 direction)
    {
        currentHealth -= Hurt;

        theplayer.Knockback(direction);

      healthBar.SetHealth(currentHealth);


        //game over 
        if (currentHealth <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}