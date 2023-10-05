using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smacked : MonoBehaviour
{
    //[Unity3d Episode 13] Enemy Mario death from jumping on top,
    //by TheSenpaiCode(https://www.youtube.com/watch?v=Es6AdrUCqdU)
    //full script used and adapted to my game

    private Animator animator;
    private bool isDead = false;

    void Start()
    {
        animator = gameObject.GetComponentInParent<Animator>();
    }

    
    void Update()
    {

    }

    //player kills enemy event 

    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Player")
        {

             foreach (Transform child in transform)
             {
                child.gameObject.SetActive(false); //when enemy is killed it can't also give damage to player 
                animator.SetBool("isDead", true);
               

             Destroy(transform.parent.gameObject, 5F);
            }
        }
    }
}
