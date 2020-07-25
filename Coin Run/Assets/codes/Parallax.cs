using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public float ScrollSpeed;

	
	// Update is called once per frame
	void Update () {
		float x = Mathf.Repeat (Time.time * ScrollSpeed, 1);
		this.GetComponent<Renderer> ().sharedMaterial.SetTextureOffset ("_MainTex", new Vector2 (x, 0f));
	}
}
