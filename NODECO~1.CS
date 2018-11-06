using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodeColourControl : MonoBehaviour {

	public Sprite spriteOff;
	public Sprite spriteP1;
	public Sprite spriteP2;
	public int currentState; // 0 = off, 1 = player1, 2 = player2

	public AudioClip audioClip;
	public AudioSource audioSource;

	GameObject globalElement;
	PlayerPoints playerPoints;

	void Start () {
		currentState = 0;

		audioSource = this.gameObject.GetComponent<AudioSource> ();

		globalElement = GameObject.Find ("GlobalElement");
		playerPoints = globalElement.GetComponent<PlayerPoints> ();

	}

	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.tag == "P1" || other.tag == "P2") {
			playAudio ();
		}

		if (other.CompareTag ("P1")) {
			
			if (GetComponent<SpriteRenderer> ().sprite == spriteP1) {
				
				GetComponent<SpriteRenderer> ().sprite = spriteOff;
				currentState = 0;
			} 
			else if (GetComponent<SpriteRenderer> ().sprite == spriteP2) {
				GetComponent<SpriteRenderer> ().sprite = spriteP1;
				currentState = 2;
			}
		 	else {
			GetComponent<SpriteRenderer> ().sprite = spriteP1;
			currentState = 1;
			}

		if (currentState == 0) {
			playerPoints.decreaseHackerPoints ();
		} else if (currentState == 1) {
			playerPoints.increaseHackerPoints ();
		} else if (currentState == 2) {
			playerPoints.increaseHackerPoints ();
			playerPoints.decreaseAntiHackerPoints ();
		}
	}

		if (other.CompareTag("P2")){

			if (GetComponent<SpriteRenderer>().sprite == spriteP2) {
				GetComponent<SpriteRenderer> ().sprite = spriteOff;
				currentState = 0;
			}else if (GetComponent<SpriteRenderer> ().sprite == spriteP1) {
				GetComponent<SpriteRenderer> ().sprite = spriteP2;
				currentState = 1;
			} else {
				GetComponent<SpriteRenderer> ().sprite = spriteP2;
				currentState = 2;
			}

			if (currentState == 0) {
				playerPoints.decreaseAntiHackerPoints ();
			}else if(currentState == 1){
				playerPoints.increaseAntiHackerPoints();
				playerPoints.decreaseHackerPoints ();					
			} else if (currentState == 2) {
				playerPoints.increaseAntiHackerPoints();
			}
		}
	}

	void playAudio () {

		audioSource.clip = audioClip;
		audioSource.Play ();

	}


}
