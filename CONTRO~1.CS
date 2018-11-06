using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlsButton : MonoBehaviour {

	public GameObject controlsCard;
	public GameObject creditsCard;
	public bool showOne;
	public bool showTwo;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (showOne == true) {
			controlsCard.SetActive (true);
			creditsCard.SetActive(false);
		}else if(showOne == false){
			controlsCard.SetActive (false);
		}

		if (showTwo == true) {
			controlsCard.SetActive (false);
			creditsCard.SetActive(true);
		}else if(showTwo == false){
			creditsCard.SetActive (false);
		}
	}



	public void showControls (){
	
		showOne = !showOne;
		showTwo = false;

	}

	public void showCredits () {
	
		showTwo = !showTwo;
		showOne = false;

	}
}
