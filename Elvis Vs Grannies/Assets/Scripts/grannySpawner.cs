using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grannySpawner : MonoBehaviour {
	public GameObject granny;
	public int grannyMax;
	private int ctr = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawnGranny", 3.0f, 5.0f);
	}

	// Update is called once per frame
	void Update() {
		if (ctr >= grannyMax) {
			CancelInvoke ();
		}
	}
	
	void spawnGranny () {
		Vector3 coords = new Vector3 (Random.Range (-4.5f, 4.5f), 0, Random.Range (-4.5f, 4.5f));

		GameObject spawn = (GameObject)Instantiate (granny);
		spawn.transform.position = coords;
		spawn.transform.SetParent (this.transform);
		ctr++;
	}
}
