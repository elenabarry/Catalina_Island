using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class Typewriter : MonoBehaviour
{

    //Unity C# Tutorial: How to Make a Typewriter Effect for UI Text WITH COROUTINES, by Anthony Nahat (https://www.youtube.com/watch?v=ugiaWcydlwQ&t=439s)
    //full script used and adapted to my game

    public TextMeshProUGUI displayedText;
    public TextMeshProUGUI inputText;
    public TextMeshProUGUI italicText;

    private string outputString = null;
    private int i = -1;
    private bool done;
    private bool changed;

    public float charsPerSec = 10;
    
    // Start is called before the first frame update
    void Awake()
    {
        BeginTypewrite(inputText.text);
    }

    // Update is called once per frame
    void Update()
    {
      //  if (!done)
      //  {
      //      displayedText.text = Typewrite(inputText.text);
      //  }
       // else
        //{
          //  if(!changed)
          //  {
            //    displayedText.text = italicText.text;
            //    changed = true; 
           // }
       // }

        if (done)
        {
            if (!changed)
            {
                displayedText.text = italicText.text;
                changed = true;
               // yield return new WaitForSeconds(5f);
                displayedText.enabled = false; 
           }
      }
    }

    private string Typewrite(string text)
    {
        i++;
        char[] characters = text.ToCharArray();
        outputString = outputString + characters[i].ToString();
        if (i == (characters.Length - 1))
        {
            done = true;
            
         }
        return outputString;
    }

    private void BeginTypewrite(string text)
    {

        char[] characters = text.ToCharArray();
        StartCoroutine(Type(characters, charsPerSec));

    }
    private IEnumerator Type(char[] chars, float charsPerSec)
    {
        i++;
        outputString = outputString + chars[i].ToString();

       displayedText.text = outputString;

        yield return new WaitForSeconds(1 / charsPerSec);
        if (i == chars.Length -1)
        {
            done = true;

        }
        else
        {

            StartCoroutine(Type(chars, charsPerSec));

        }

   }
}
