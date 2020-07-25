using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResPou : MonoBehaviour {

	public Sprite PauseSprite;
	public Sprite ResumeSprite;
	bool pasued=false;

	public void PasueOrResume(){
	
	
		if (pasued) {
			Time.timeScale = 1;
			this.GetComponent<Image> ().sprite = PauseSprite;
			GameObject.Find ("Main Camera").GetComponent<AudioSource> ().Play ();
			pasued = false;
		
		} else {
			Time.timeScale = 0;
			this.GetComponent<Image> ().sprite = ResumeSprite;
			GameObject.Find ("Main Camera").GetComponent<AudioSource> ().Pause ();
			pasued = true;
		
		
		}
	
	
	
	
	
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
