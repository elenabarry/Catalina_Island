using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public static int objects = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        objects++;
    }
    private void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
            objects--;
        gameObject.SetActive(false);
    }
}
