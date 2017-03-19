using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	public Text question;
	public Text instructions;
	int guess;
	int max;
	int min;
	//string scene;
	
	void Start () {
	//StartGame();
		min = 1;
		max = 1000;
		guess = 500;
		question.text = "Is your number higher or lower than " + guess + "?";
		instructions.text = "[Press the up arrow or the button if your number is higher, down or button if lower, enter if I got it right!]";
		max += 1;
	}
	
	void Update () {
	if(Input.GetKeyDown(KeyCode.DownArrow)) {
	Lower ();
	}
	if(Input.GetKeyDown(KeyCode.UpArrow)){
	Higher ();
	}
	/*if(Input.GetKeyDown (KeyCode.Return)) {
	Win (scene);
	}*/
	}
	
	/*void StartGame(){
	instructions.text = "[Press the up arrow or the button if your number is higher, down or button if lower, enter if I got it right!]";
	min = 1;
	max = 1000;
	guess = 500;
	}*/
	
	public void Higher(){
	min = guess;
	guess = (max+min) / 2;
	question.text = "Is your number higher or lower than " + guess + "?";
	}
	
	public void Lower(){
	max = guess;
	guess = (max+min) / 2;
	question.text = "Is your number higher or lower than " + guess +"?";
	}
	
	/*public void Win(string scene){
	Application.LoadLevel (scene);
	}*/
}

