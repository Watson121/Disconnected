using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {

	public GameObject Menu;
	public Timer timeScript;
	public ControlsNew1 playerOne;
	public ControlsNew playerTwo;
	bool activeMenu;

	public AudioSource audioSource;
	public AudioClip[] audioClip;

	void Start () {
		Menu.SetActive(false);

		audioSource = this.gameObject.GetComponent<AudioSource> ();

	}


	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {
			activeMenu = !activeMenu;
			Menu.SetActive (activeMenu);
			playAudio ();
		}

		if (Menu.activeInHierarchy == true) {
			timeScript.gamePaused = true;
			playerOne.enabled = false;
			playerTwo.enabled = false;
		} else if (Menu.activeInHierarchy == false) {
			timeScript.gamePaused = false;
			playerOne.enabled = true;
			playerTwo.enabled = true;
		}
	}

	public void Continue () {
		Menu.SetActive (false);
		playButtonAudio ();
	}

	public void Exit () {
	
		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
		playButtonAudio ();
	}

	void playAudio () {
	
		audioSource.clip = audioClip[0];
		audioSource.Play ();
	
	}

	void playButtonAudio (){
		audioSource.clip = audioClip[1];
		audioSource.Play ();
	}

}
