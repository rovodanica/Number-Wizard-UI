using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	public Text question;
	int guess;
	int max;
	int min;
	public int maxGuesses = 7;
	
	void Start () {
	StartGame();
		min = 1;
		max = 1000;
		guess = 500;
		question.text = "Is your number higher or lower than " + guess.ToString() + "?";
		max += 1;
	}
	
	void StartGame(){
	min = 1;
	max = 1000;
	guess = 500;
	}
	
	public void Higher(){
	min = guess;
	NextGuess ();
	}
	
	public void Lower(){
	max = guess;
	NextGuess ();
	}
	
	public void NextGuess(){
		guess = (max+min) / 2;
		question.text = "Is your number higher or lower than " + guess.ToString() + "?";
		maxGuesses--;
		if(maxGuesses <= 0) {
		Application.LoadLevel("Lose");
		}
	}
}

