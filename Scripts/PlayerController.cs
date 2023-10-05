using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerController : MonoBehaviour
{
    //player movement

    private CharacterController controller;

    public float speed = 5.0F;
    public float jumpSpeed = 5.0F;
    public float gravity = 20.0F;
    public float rotateSpeed = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    //coin collection
    public AudioClip coinSound;

    //food count text 
    public Text scoreText;
    public Text winText;

    //food pick ups
    public int count;
    private int numPickups = 16;
    public List<GameObject> pickUps;

    //player animation
    private Animator animator;
    private bool isRunning = false;

    //player velocity
    public GameObject player;
    private Vector3 velocity;
    private Vector3 previous;
    private float velMag;

    //knockback 
    public float knockBackForce;
    public float knockBackTime;
    private float knockBackCounter;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        //pick ups
        foreach (Transform child in transform)
        {
            pickUps.Add(child.gameObject);
        }

        count = 0;
        SetCountText();

    }

    void Update()
    {
        Animation();
        PlayerMovement();

    }

    void Animation()
    {
        //check if player is moving by using player velocity
        velocity = ((player.transform.position - previous) / Time.deltaTime);

      
        velMag = velocity.magnitude;

        if (velMag == 0)
        {

            animator.SetBool("isRunning", false);
        }
        else
        {

            animator.SetBool("isRunning", true);
        }


        previous = player.transform.position;

    }

    void PlayerMovement()
    {


        //Easiest way to Move, Rotate and Jump Player in Unity 3d, by Learn Everything Fast
        //(https://www.youtube.com/watch?v=e5g1nJcjz-M&feature=emb_title)
        //full script used and adapted to my game

      
        if (knockBackCounter <= 0)
        {
            
            float yVel = moveDirection.y;

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            moveDirection += (Vector3.up * yVel);

            //Unity3D - Player Jump (with Double Jump), by KINGBEKIR (https://www.youtube.com/watch?v=OqTwWIoR75Y)
            //full script used and adapted to my game


            //Currently allows player to jump ulimitedly 

            if (Input.GetKeyDown("space"))
            {

                moveDirection.y = jumpSpeed;

            }

            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
            transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

        }

        else
        {
            knockBackCounter -= Time.deltaTime;
        }


    }

    //pick up event 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);

            AudioSource.PlayClipAtPoint(coinSound, transform.position, 20);

            count++;

            SetCountText();

            pickUps.Remove(other.gameObject);
        }


    
    }



    public void SetCountText()
    {
        scoreText.text = "Food: " + count.ToString();

        if (count >= numPickups)
        {
            winText.text = "You win!";

        }

    }

    //Make A 3D Platformer in Unity #13 Knockback
    //, by gamesplusjames(https://www.youtube.com/watch?v=MwojdoYu0lE)
    //full script used and adapted to my game


    public void Knockback(Vector3 direction) {

        knockBackCounter = knockBackTime;

        moveDirection = direction * knockBackForce;

        moveDirection.y = knockBackForce;

    }


}
