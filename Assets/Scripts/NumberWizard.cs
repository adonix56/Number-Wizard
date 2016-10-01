using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int min;
	int max;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame(){
		min = 1;
		max = 1000;
		guess = 500;
		print ("###########What up NIGGAS##########");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		max = max + 1;
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, Enter = equal");
	}

	void NextGuess() {
		guess = (max + min) / 2;
		print ("Is your number " + guess + "?");
		print ("Up = higher, down = lower, Enter = equal");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//print ("Boom Bitch");
			min = guess;
			NextGuess ();
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print ("Down Bitch");
			max = guess;
			NextGuess ();
		}
		else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I win!!");
			StartGame();
		}
	}
}
