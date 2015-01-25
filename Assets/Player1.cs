using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rg = GetComponent<Rigidbody> ();
		if (Input.GetKey (KeyCode.UpArrow)) {
						rg.velocity = new Vector3 (0, 0, 20f);
		} else if(Input.GetKey (KeyCode.DownArrow)) {
			rg.velocity = new Vector3 (0, 0, -20f);
		} else if(Input.GetKey (KeyCode.RightArrow)) {
			rg.velocity = new Vector3 (20f, 0, 0);
		} else if(Input.GetKey (KeyCode.LeftArrow)) {
			rg.velocity = new Vector3 (-20f, 0, 0);
		} else {
			rg.velocity = new Vector3 (0, 0, 0);
		}

		if (Input.GetKey (KeyCode.M)) {
			rg.AddTorque(0,30,0);
		} else if (Input.GetKey (KeyCode.N)) {
			rg.AddTorque(0,-30,0);
		}
	}
}
