using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialAudioSwitch : MonoBehaviour {

	public AudioClip Audio1;
	public AudioSource AudioSource;

	//public GameObject audio1;
	//public GameObject audio2;
	//public GameObject audio3;

	// Use this for initialization
	void Start () {
		//audio1.Play ();
		AudioSource.clip = Audio1;
		AudioSource.Play ();
		//this.GetComponents<AudioSource> ().clip = Audios [0];
		//this.GetComponents<AudioSource> ().play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
