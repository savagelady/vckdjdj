using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// 
		//Enemy movement using Rigidbody
		GetComponent<Rigidbody> ().AddForce (new Vector3 (0f, 2f, 0f));
	}
}
