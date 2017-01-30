using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class control : MonoBehaviour {
	public Text ip;
	void Awake() {
		Left ();
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		// Your player movement using Rigidbody Velocity
		this.GetComponent<Rigidbody> ().velocity= new Vector2 (5f * Input.GetAxis("Horizontal"),0f);


	}

	public void  Left() {
		this.GetComponent<Rigidbody> ().velocity = new Vector2 (-2f , 0f);	
	}

	public void Right() {
	
	
	
	}

}
