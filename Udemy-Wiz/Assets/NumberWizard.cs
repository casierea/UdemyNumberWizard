using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int min = 1;
	int max = 1000;
	int guess = 500;
	
	
	// Use this for initialization
	void Start ()
	{
		Debug.Log("Hello Ducky");
		Debug.Log("Hey Let us play a game.");
		Debug.Log("The highest number you can pick is:" + max);
		Debug.Log("The lowest number you can pick is: " + min);
		Debug.Log("Tell me if your number is higher or lower than: " + guess);
		Debug.Log("Push up = higher, Push Down = lower, Push Enter =  Correct");

		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Debug.Log("Is this your number?");
			min = guess;
			guess = (max + min) / 2;
			Debug.Log("Is it higher or lower than.." + guess);
			
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			//Debug.Log("Is your number lower or higher than this?");
			max = guess;
			guess = (max + min) / 2;
			Debug.Log("Is it higher or lower than.." + guess);
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("Your number is " + guess);
			Debug.Log("Oooza Ballooza! We are the Champions! OF THE WORLD!");
			print("CHAMPIONS!");
		}
	}
}
