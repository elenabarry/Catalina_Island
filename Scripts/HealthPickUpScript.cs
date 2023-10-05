using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUpScript : MonoBehaviour
{
    //Health Pickups in Unity, by ThinkBot Labs
    //(https://www.youtube.com/watch?v=TQhzBAKaOTE)
    //full script used and adapted to my game

    public AudioClip healthSound;
    PlayerHealth playerHealth;
    public HealthBar healthBar;


    public int healthBonus = 10;

    
    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //check health is below maximum to be able to pick up health 
        if (playerHealth.currentHealth < playerHealth.maxHealth)
        {
            AudioSource.PlayClipAtPoint(healthSound, transform.position);

            Destroy(gameObject); 

            playerHealth.currentHealth = playerHealth.currentHealth + healthBonus;

            healthBar.SetHealth(playerHealth.currentHealth);
        }
        
    }
}
