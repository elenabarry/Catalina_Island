using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    //WINNING LEVELS - How to make a Video Game in Unity(E09), by Brakeys(https://www.youtube.com/watch?v=Iv7A8TzreY4)
    //adapted script 
    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel(); 

    }
}
