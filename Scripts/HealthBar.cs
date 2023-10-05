using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	//How to make a HEALTH BAR in Unity!, by 
	//Brackeys(https://www.youtube.com/watch?v=BLfNP4Sc_iA)
	//full script used and adapted to my game

	public Slider slider;

	public void SetMaxHealth(int health)
	{
		slider.maxValue = health;
		slider.value = health;

	}

	public void SetHealth(int health)
	{
		slider.value = health;

		
	}

}