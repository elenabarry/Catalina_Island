using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectToCollect : MonoBehaviour
{
    //Unity 5 - Collecting Objects, by Lurony (https://www.youtube.com/watch?v=NebeDbWjIXA)
    //full script used
    public AudioClip bookSound; 
    public static int objects = 0;
   

    private void Awake()
    {
        objects++;
    }
    private void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
            objects--;
        AudioSource.PlayClipAtPoint(bookSound, transform.position); 
        gameObject.SetActive(false);
    }
}
