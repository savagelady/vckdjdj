using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class LocalPlayer : NetworkBehaviour {
	// Variable Declaration
	public Text ip;
	GameObject bullet;
	[SyncVar]
	public bool m_red;
	[SyncVar]
	public bool m_blue;
	[SyncVar]
	public bool m_green;
	[SyncVar]
	public bool m_white;
	// Use this for initialization
	void Start () {
		if (isLocalPlayer) {
			GameObject.Find ("Canvas").GetComponent<Test> ().player = this;
		}
		//Violet ();
		// Assigning the prefabs to bullet gameobject
		bullet = (GameObject)Resources.Load ("bullet");
		// Invoking Register Method
		Register ();
		if (isLocalPlayer) {
			// this is you
			// isLocalPlayer runs on the current player 
			//
			//GetComponent<BoxCollider>().enabled = false;

			// Activate the control when the player is playing
			GetComponent<control> ().enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	//	CmdChange ();

		if (isLocalPlayer) {
			if (m_blue) {
				this.GetComponent<Renderer> ().material.color = Color.blue;	
			}
		
		}
	

		GameObject.Find("ip").GetComponent<Text>().text = "Ip Address" + Network.player.ipAddress;
	
		// Localplayer 
		if (isLocalPlayer) {
			
			if (Input.GetKeyDown (KeyCode.Space)) {
				// Invoke CmdSpawn to Instantiate the Gameobject to the seen
				CmdSpawn ();
			}
		}
	}
	[Command]
	void CmdSpawn(){

		//Network Instantiating process 
		// Assigning the Instantiated object to the Gameobject buls
		GameObject buls = (GameObject)Instantiate (bullet, transform.position, transform.rotation);

		NetworkServer.Spawn (buls);

	}

	void Register(){
	//Register the prefab 
		ClientScene.RegisterPrefab (bullet);
	}


	[ClientRpc]
	public void RpcChange () {
		//Violet ();


					this.GetComponent<Renderer> ().material.color = Color.red;	

	}

	[ClientRpc]
	public void RpcChange2 () {
		//Violet ();

	
		this.GetComponent<Renderer> ().material.color = Color.green;	

	}
	[ClientRpc]
	public void RpcChange3 () {
		//Violet ();

	
		this.GetComponent<Renderer> ().material.color = Color.magenta;	

	}

	[ClientRpc]
	public void RpcChange4 () {
		//Violet ();


		this.GetComponent<Renderer> ().material.color = Color.blue;	
	
	}

	[Command]
	public void CmdChange1 () {
		//Violet ();
		//m_blue = true;
		this.GetComponent<Renderer> ().material.color = Color.red;	

	}
	[Command]
	public void CmdChange2 () {
		//Violet ();
		//m_red = true;
		this.GetComponent<Renderer> ().material.color = Color.blue;	

	}
	[Command]
	public void CmdChange3 () {
		//Violet ();
		//m_green = true;
		this.GetComponent<Renderer> ().material.color = Color.grey;	

	}
	[Command]
	public void CmdChange4 () {
		//Violet ();
		//m_white = true;
		this.GetComponent<Renderer> ().material.color = Color.green;	

	}







}
