using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 CharacterPositon = GameObject.Find ("Character").transform.position;
		this.transform.position = new Vector3 (CharacterPositon.x + 5, this.transform.position.y, CharacterPositon.z-5);
	}
}
