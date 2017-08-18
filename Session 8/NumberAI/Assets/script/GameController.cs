using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {


	public Text displayText;
	public Button Higher;
	public Button Lower;
	public Button Yes;
	public Text endText;
	public Text error;
	public Button playAgain;

	int min = 0;
	int max = 100;
	int AIchoose;
	public void gamePlay(){

		displayText.gameObject.SetActive (true);
		playAgain.gameObject.SetActive (false);
		error.gameObject.SetActive(false);
		endText.gameObject.SetActive (false);
		Lower.gameObject.SetActive (true);
		Higher.gameObject.SetActive (true);
		Yes.gameObject.SetActive (true);



		if (min > max) {

			error.text = "Out of range";
			error.gameObject.SetActive(true);

			Lower.gameObject.SetActive (false);

			Higher.gameObject.SetActive (false);

			Yes.gameObject.SetActive (false);

			displayText.gameObject.SetActive (false);

			playAgain.gameObject.SetActive (true);

		}


		AIchoose = Random.Range(min, max);

		displayText.text = "Pick a number between 0 and 100 but don't tell me you Puny Human. Is your number " + AIchoose;



	}



	public void c_Lower(){

		max = AIchoose - 1;

		gamePlay ();

	}

	public void c_Highter(){

		min = AIchoose + 1;

		gamePlay ();

	}

	public void c_yes(){
		Higher.gameObject.SetActive (false);

		Lower.gameObject.SetActive (false);

		Yes.gameObject.SetActive (false);

		endText.gameObject.SetActive(true) ;

		displayText.gameObject.SetActive (false);

		endText.text = " Yeah thats cool";

		playAgain.gameObject.SetActive (true);



	}
		


	public void play_again(){
		AIchoose = Random.Range(min, max);

		displayText.text = "Pick a number between 0 and 100 but don't tell me you Puny Human. Is your number " + AIchoose;

		playAgain.gameObject.SetActive (false);

	}

	void Start () {

		gamePlay ();



	}


	void Update () {



	}

}