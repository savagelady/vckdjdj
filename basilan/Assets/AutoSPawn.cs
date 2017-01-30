using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class AutoSPawn : NetworkBehaviour {
	// Variable Declaration
	GameObject enemy;
	float count;
	// Use this for initialization
	void Start () {
		
		// Assigning enemy prefab to game object variable
		enemy = (GameObject)Resources.Load ("Enemy");
		Send ();
	}
	
	// Update is called once per frame
	void Update () {
		//make count as a timer
		count += Time.deltaTime;
		if (count >= 1.5f) {
			//Invoke CmdCom to instantiate
			CmdCom ();
			//reset the count
			count = 0;

		}
	}
	[Command]
	void CmdCom() {
		// Object Spawning
		GameObject game = (GameObject)Instantiate (enemy, transform.position, transform.rotation);
	//Spawn through server
		NetworkServer.Spawn (game);

	}

	void Send() {
	//Register Prefabs to server
		ClientScene.RegisterPrefab (enemy);
	}


}
