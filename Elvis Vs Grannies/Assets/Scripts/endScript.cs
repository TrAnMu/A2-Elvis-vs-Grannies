using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Reset
		if (Input.GetKeyDown (KeyCode.R)) {
			grannyController.grannies = 3;
			UnityEngine.SceneManagement.SceneManager.LoadScene ("StartScene");
		}

		// Quit
		if (Input.GetKeyDown (KeyCode.Q)) {
			Application.Quit ();
		}
	}
}
