using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grannyController : MonoBehaviour {
	private Animator animator;
	public Rigidbody rb;
	public GameObject elvis;
	private float maxSpeed = 2.0F;
	private bool falling = false;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
		elvis = GameObject.FindWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		if (falling == false && Physics.Raycast (transform.position + Vector3.up, Vector3.down)) {
			// Chase!
			if (Vector3.Distance (elvis.transform.position, transform.position) <= 5) {
				animator.SetBool ("isWalking", true);
				Vector3 grannyToElvis = elvis.transform.position - transform.position;
				grannyToElvis.y = 0.0F;
				grannyToElvis *= 0.01F;
				Vector3 newVelocity = rb.velocity + grannyToElvis;
				rb.velocity = Vector3.ClampMagnitude (newVelocity, maxSpeed);

				Quaternion look = new Quaternion ();
				look.SetLookRotation (rb.velocity, Vector3.up);
				rb.MoveRotation (look);
			} else { // ...or Stop.
				animator.SetBool ("isWalking", false);
				rb.velocity = Vector3.zero;
			}
		} else {
			if (falling == false) {
				animator.SetBool ("isFalling", true);
				falling = true;
				rb.constraints = RigidbodyConstraints.None;
			}

			rb.velocity -= new Vector3 (0, 2.0F * Time.deltaTime, 0);
		}
	}
}
