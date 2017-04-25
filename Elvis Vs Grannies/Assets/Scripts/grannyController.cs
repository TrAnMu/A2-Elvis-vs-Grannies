using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grannyController : MonoBehaviour {
	static Animator animator;
	public Transform elvis;
	public float speed = 2.0F;
	public float rotationSpeed = 100.0F;

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
			animator.SetBool ("isWalking", true);
		} else {
			animator.SetBool ("isWalking", false);
		}

		if (transform.position.y < -1.0f) {
			animator.SetBool ("isFalling", true);
		}
	}
}
