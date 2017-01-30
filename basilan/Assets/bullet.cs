using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class bullet : NetworkBehaviour {
		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Get the component of the object attached Rigidbody then use Addforce so the bullet will move
		GetComponent<Rigidbody> ().AddForce (new Vector2 (0f, -5f));
	}

	void OnTriggerEnter(Collider other){
		// if the other collider is enemy
		if (other.gameObject.tag == "enemy") {
			// Destroy the gameObject
			Destroy (other.gameObject);
		}
	}
}
