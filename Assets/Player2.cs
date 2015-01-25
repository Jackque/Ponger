using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rg = GetComponent<Rigidbody> ();
		if (Input.GetKey (KeyCode.W)) {
			rg.velocity = new Vector3 (0, 0, 20f);
		} else if(Input.GetKey (KeyCode.S)) {
			rg.velocity = new Vector3 (0, 0, -20f);
		} else if(Input.GetKey (KeyCode.D)) {
			rg.velocity = new Vector3 (20f, 0, 0);
		}else if(Input.GetKey (KeyCode.A)) {
			rg.velocity = new Vector3 (-20f, 0, 0);
		}
		else {
			rg.velocity = new Vector3 (0, 0, 0);
		}

		if (Input.GetKey (KeyCode.E)) {
			rg.AddTorque(0,30,0);
		} else if (Input.GetKey (KeyCode.Q)) {
			rg.AddTorque(0,-30,0);
		}
	}
}
