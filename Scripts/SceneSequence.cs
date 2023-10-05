using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSequence : MonoBehaviour
{

    //Mini Unity Tutorial - How To Create Splash Screens, Jimmy Vegas(https://www.youtube.com/watch?v=ADJ2SYm0oBU)
    //adapted script

    public static int SceneNumber; 
   
    void Start()
    {
        if (SceneNumber == 0)
        {
            StartCoroutine(ToMainMenu());
        }
        
    }


    IEnumerator ToMainMenu()
    {

        yield return new WaitForSeconds(2);
        SceneNumber = 1;
        SceneManager.LoadScene(1);
    }

}
