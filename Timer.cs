using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Timer : MonoBehaviour {

	public float startTime = 120;
	public int currentTime;

	public bool gamePaused, gameHasFinished;

	GameObject timeText;
	Text timerTexter;

    private GameObject playerOne;
    private GameObject playerTwo;

    private ControlsNew1 playerOneScript;
    private ControlsNew playerTwoScript;

	public PlayerPoints playerPoints;

	// Use this for initialization
	void Start () {

		timeText = GameObject.Find("Time");
		timerTexter = timeText.GetComponent<Text>();

        playerOne = GameObject.Find("Hacker");
        playerTwo = GameObject.Find("AntiHacker");

        playerOneScript = playerOne.GetComponent<ControlsNew1>();
        playerTwoScript = playerTwo.GetComponent<ControlsNew>();

        gamePaused = false;
		gameHasFinished = false;
	}
	
	// Update is called once per frame
	void Update () {

		int time = (int)startTime;

		timerTexter.text = time.ToString();

		if (startTime > 0) {
			if (gamePaused == false && gameHasFinished == false) {
				startTime -= Time.deltaTime;
			}
		}

        if(gameHasFinished == true)
        {
            playerOneScript.enabled = false;
            playerTwoScript.enabled = false;
        }


		if (startTime <= 0) {
			playerPoints.determineAfterTime();
		}
	}
}
