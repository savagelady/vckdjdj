using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Starting : NetworkDiscovery {

	// Use this for initialization
	public override void OnReceivedBroadcast (string fromAddress, string data){
		NetworkManager.singleton.networkAddress = fromAddress;
		NetworkManager.singleton.StartClient ();
	}


	// Update is called once per frame
	void Update () {
		
	}
}
