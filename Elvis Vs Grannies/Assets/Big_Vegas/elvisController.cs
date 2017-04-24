using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elvisController : MonoBehaviour {
	static Animator animator;
	public float speed;
	public float rotationSpeed;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);

		if (translation != 0) {
			animator.SetBool ("isJogging", true);
		} else {
			animator.SetBool ("isJogging", false);
		}
	}
}
