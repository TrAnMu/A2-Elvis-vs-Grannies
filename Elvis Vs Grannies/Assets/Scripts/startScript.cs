using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Start
		if (Input.GetKeyDown (KeyCode.Return)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("MainScene");
		}

		// Quit
		if (Input.GetKeyDown (KeyCode.Q)) {
			Application.Quit ();
		}
	}
}
