﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class elvisController : MonoBehaviour {
	static Animator animator;
	NavMeshAgent agent;

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
	}
}
