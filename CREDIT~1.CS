using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creditsButton : MonoBehaviour {

	public GameObject creditsCards;
	public GameObject controlCard;
	public bool show;

	// Use this for initialization
	void Start () {
		show = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (show == true) {
			creditsCards.SetActive (true);
			controlCard.SetActive (false);
		} else if (show == false) {
			creditsCards.SetActive (false);
		}
	}

	public void showCredits () {
		show = !show;
	}
}
