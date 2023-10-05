using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountObjects : MonoBehaviour
{
    //Unity 5 - Collecting Objects, by Lurony (https://www.youtube.com/watch?v=NebeDbWjIXA)
    //adapted script

    public string nextLevel;
    //public GameObject objToDestroy;
    GameObject objUI;
    // Start is called before the first frame update
    void Start()
    {
        objUI = GameObject.Find("ObjectNum");
        
    }

    // Update is called once per frame
    void Update()
    {
        objUI.GetComponent<TextMeshProUGUI>().text = objectToCollect.objects.ToString();

        if (objectToCollect.objects == 4)
        {

            objUI.GetComponent<TextMeshProUGUI>().text = "";
        }

        if (objectToCollect.objects == 3)
        {
            objUI.GetComponent<TextMeshProUGUI>().text = "The Pearls of night, stolen in clearest light of day.";

        }

        if (objectToCollect.objects == 2)
        {
            objUI.GetComponent<TextMeshProUGUI>().text = "I touch your face, I'm in your words,  I'm lack of space and beloved by birds.";

        }

        if (objectToCollect.objects == 1)
        {
            objUI.GetComponent<TextMeshProUGUI>().text = "What has roots as nobody sees, Is taller than trees, Up, up it goes, And yet never grows?";
            // objUI.GetComponent<TextMeshProUGUI>().text = "What breaks but never falls?";

        }


        if (objectToCollect.objects ==0)
        {
            Application.LoadLevel(nextLevel);
            //MAKE THIS A NEW LEVEL INSTEAD
           // Destroy(objToDestroy);
            objUI.GetComponent<TextMeshProUGUI>().text = "All books collected";
            
        }

    }
}
