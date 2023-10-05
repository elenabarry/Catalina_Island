using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[Unity3d Episode 5] Knockback, Health and Damage, by TheSenpaiCode
//(https://www.youtube.com/watch?v=lGUPG7smpXo)
//full script used and adapted to my game


public class Damage : MonoBehaviour
{

    public int Hurt = 10;


    void Start()
    {

    }

    void Update()
    {

    }

    //on collision with enemy 
    private void OnTriggerEnter(Collider other)

    {

        if (other.gameObject.tag == "Player")

        {  
            //direction to propel player after being hit by enemy 
            Vector3 damageDirection = other.transform.position - transform.position;
            damageDirection = -damageDirection.normalized;



            FindObjectOfType<PlayerHealth>().DamagePlayer(Hurt, damageDirection);
           

        }
    }
}
