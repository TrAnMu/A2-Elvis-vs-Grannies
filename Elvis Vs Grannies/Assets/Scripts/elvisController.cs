using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class elvisController : MonoBehaviour {
	static Animator animator;
	NavMeshAgent agent;
	private bool paused = false;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;

			if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, 100)) {
				agent.SetDestination (hit.point);
			}
		}

		if (agent.destination != agent.nextPosition) {
			animator.SetBool ("isJogging", true);
		} else {
			animator.SetBool ("isJogging", false);
		}

		// Pause
		if (Input.GetKeyDown (KeyCode.P)) {
			if (paused == false) {
				paused = true;
				Time.timeScale = 0.0F;
			} else {
				paused = false;
				Time.timeScale = 1.0F;
			}
		}

		// Reset
		if (Input.GetKeyDown (KeyCode.R)) {
			if (paused == true) {
				paused = false;
				Time.timeScale = 1.0F;
			}

			UnityEngine.SceneManagement.SceneManager.LoadScene (0);
		}

		// Quit
		if (Input.GetKeyDown (KeyCode.Q)) {
			Application.Quit ();
		}

	}
}
