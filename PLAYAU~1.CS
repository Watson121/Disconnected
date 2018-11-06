using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudioAtJunction : MonoBehaviour {

	public AudioClip audioClip;
	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = this.gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "P1" || other.tag == "P2") {
			audioSource.clip = audioClip;
			audioSource.Play ();
		}
	}



}
