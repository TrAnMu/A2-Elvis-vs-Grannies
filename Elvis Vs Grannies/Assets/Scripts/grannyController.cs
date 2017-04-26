using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grannyController : MonoBehaviour {
	private Animator animator;
	public GameObject elvis;
	public float speed = 2.0F;
	public float rotationSpeed = 100.0F;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		elvis = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		/*float translation = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);

		if (translation != 0) {
			animator.SetBool ("isWalking", true);
		} else {
			animator.SetBool ("isWalking", false);
		}*/

		if (Vector3.Distance (elvis.transform.position, transform.position) <= 5) {
			//TODO GET HIM!
		}

		if (transform.position.y < -1.0F) {
			animator.SetBool ("isFalling", true);
		}
	}
}
