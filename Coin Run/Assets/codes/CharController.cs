using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour {

	bool jump=false;
	bool down=false;
	bool grounded = true;
	public string Lose;
	public string Win;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown (KeyCode.Space))&& grounded) {

			jump = true;
	
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			down = true ;
		}
		if (this.transform.position.y <= -10) {
			LoseLevel (Lose);
		}
	


	}



	void LoseLevel(string loselv){
		Application.LoadLevel (loselv);
	}

	void FixedUpdate(){
		this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (5f, this.GetComponent<Rigidbody2D> ().velocity.y);
		if (jump && grounded) {
			this.GetComponent<Animator> ().speed = 0;
			this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (500, 1000f));
			jump = false;
			grounded = false;
		}
		if (down) {
			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, -500f));
			down = false;
		
		}
	
	}
	void OnCollisionEnter2D(){

		grounded=true;
		this.GetComponent<Animator>().speed=1;
	

	}


	void OnTriggerEnter2D(Collider2D other){
		Destroy (other.gameObject);
		if (other.gameObject.tag == "finish") {
			Application.LoadLevel (Win);
		
		}
		this.GetComponent<AudioSource> ().Play ();
	
		score++;
		UpdateScore ();
	}

	int score=0;

	void UpdateScore(){
		GameObject.Find ("Score").GetComponent<UnityEngine.UI.Text> ().text = "Score: " + this.score;
	
	
	
	}



}
