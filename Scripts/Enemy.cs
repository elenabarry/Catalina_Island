using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    //How do I make an enemy chase the player with a C script?,
    //answered by metalted, (https://answers.unity.com/questions/1240332/how-do-i-make-an-enemy-chase-the-player-with-a-c-s.html)
    //full script used and adapted to my game


    public Transform player;

    //Distance the enemy will walk towards the player

    public float walkingDistance;

    //Time to complete journey between enemy position and the players position

    public float smoothTime;

    //velocity of enemy 

    private Vector3 smoothVelocity = Vector3.zero;
  

    private Animator animator;
    private bool isRunning = false;
    private CharacterController controller;
 

    private void Start()
    {
        animator = GetComponent<Animator>();
        controller = GameObject.Find("Player").GetComponent<CharacterController>();

        //https://www.youtube.com/watch?v=9-vHthQJceY

        switch (GameValues.Difficulty)
        {
            case GameValues.Difficulties.Easy:
                walkingDistance = 10f;
                smoothTime = 10.0f;
                break;
            case GameValues.Difficulties.Medium:
                walkingDistance = 20f;
                smoothTime = 6.0f;
                break;
            case GameValues.Difficulties.Hard:
                walkingDistance = 30f;
                smoothTime = 3.0f;
                break;


        }

    }

    void Update()
    {

        //while player is grounded look at player

        if (controller.isGrounded)
        {
            transform.LookAt(player);
        }

        //Calculate distance between player

        float distance = Vector3.Distance(transform.position, player.position);

     
        if (distance < walkingDistance)
        {
            animator.SetBool("isRunning", true);

            //Move the enemy towards the player with smoothdamp

            transform.position = Vector3.SmoothDamp(transform.position, player.position, ref smoothVelocity, smoothTime);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
}
