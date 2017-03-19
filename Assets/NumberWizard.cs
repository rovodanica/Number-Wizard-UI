using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	public Text question;
	public Text guesses;
	int guess;
	int max;
	int min;
	public int maxGuesses = 10;
	
	void Start () {
	StartGame();
		min = 1;
		max = 1000;
		guess = Random.Range (min,max+1);
		question.text = "Is this your number?  " + guess.ToString();
		guesses.text = "Number of guesses left: " + maxGuesses.ToString();
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
		guess = Random.Range(min,max+1);
		question.text = "Is this your number?  " + guess.ToString();
		maxGuesses--;
		guesses.text = "Number of guesses left: " + maxGuesses.ToString();
		if(maxGuesses < 0) {
		Application.LoadLevel("Lose");
		}
	}
}

