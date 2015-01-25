
using UnityEngine;
using System.Collections;

public class Boule : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Rigidbody rg = GetComponent<Rigidbody> ();
		rg.velocity = new Vector3 (3, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rg = GetComponent<Rigidbody> ();
		if (Input.GetKeyDown (KeyCode.Space)) {

			int speed = Random.Range(-15,15);
			rg.velocity = new Vector3(speed, speed, speed);
		}
	}
}
