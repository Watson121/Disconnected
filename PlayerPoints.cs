using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerPoints : MonoBehaviour {

	const int levelOnePoint = 7;
	public int hackerPoints = 0;
	public int antiHackerPoints = 0;

	public GameObject playerOne;
	public GameObject playerTwo;
	public GameObject draw;

	public ControlsNew1 playerOneScript;
	public ControlsNew playerTwoScript;
	public Timer pause;

	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		playerOne.SetActive (false);
		playerTwo.SetActive (false);
		draw.SetActive (false);

		audioSource = this.gameObject.GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (hackerPoints == levelOnePoint) {
			playerOne.SetActive(true);
			pause.gameHasFinished = true;
			playerOneScript.enabled = false;
			playerTwoScript.enabled = false;
			StartCoroutine (waitTime ());
		}else if(antiHackerPoints == levelOnePoint){
			playerTwo.SetActive(true);
			pause.gameHasFinished = true;
			playerOneScript.enabled = false;
			playerTwoScript.enabled = false;
			StartCoroutine (waitTime ());
		}
	}

	public void increaseHackerPoints(){
		hackerPoints++;
	}

	public void increaseAntiHackerPoints () {
		antiHackerPoints++;
	}

	public void decreaseHackerPoints () {
		hackerPoints--;

		if (hackerPoints <= 0) {
			hackerPoints = 0;
		}
	}

	public void decreaseAntiHackerPoints () {
		antiHackerPoints--;

		if (antiHackerPoints <= 0) {
			antiHackerPoints = 0;
		}
	}

	public void determineAfterTime () {

		if (hackerPoints > antiHackerPoints) {
			playerOne.SetActive(true);
			pause.gameHasFinished = true;
			StartCoroutine (waitTime ());
		} else if (antiHackerPoints > hackerPoints) {
			playerTwo.SetActive(true);	
			pause.gameHasFinished = true;
			StartCoroutine (waitTime ());
		}else if(hackerPoints == antiHackerPoints){
			draw.SetActive (true);
			pause.gameHasFinished = true;
			StartCoroutine (waitTime ());
		}
	}

	IEnumerator waitTime () {

		yield return new WaitForSeconds (5f);
		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);

	}
}
