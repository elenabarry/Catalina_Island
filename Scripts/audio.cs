using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{

    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.PlayDelayed(delay);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
