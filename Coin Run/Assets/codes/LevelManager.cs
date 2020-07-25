using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LevelManage(string LevelNamge){
	
		Application.LoadLevel (LevelNamge);
	}
	public void LevelQuit(){
		Application.Quit ();
	}
}
