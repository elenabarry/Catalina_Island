using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//#11 Make an Air Hockey Game in Unity - DIFFICULTY SELECTOR - Tutorial for Beginners, by Reso Coder (https://www.youtube.com/watch?v=9-vHthQJceY)
//adapted script

public class MainMenu : MonoBehaviour
{
    public GameObject DifficultyToggles;


    private void Start()

    {
        
        DifficultyToggles.transform.GetChild((int)GameValues.Difficulty).GetComponent<Toggle>().isOn = true;
    }

    public void PlayGame()
    {
        

       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
 
        
        
    }

    public void QuitGame()
    {
        Application.Quit(); 


    }

    #region Difficulty
    public void SetEasyDifficulty(bool isOn)
    {

        if (isOn)
        
            GameValues.Difficulty = GameValues.Difficulties.Easy; 
        



    }
    public void SetMediumDifficulty(bool isOn)
    {

        if (isOn)

            GameValues.Difficulty = GameValues.Difficulties.Medium;




    }
    public void SetHardDifficulty(bool isOn)
    {

        if (isOn)

            GameValues.Difficulty = GameValues.Difficulties.Hard;




    }
    #endregion




}
