using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Nets : NetworkManager {
	public NetworkDiscovery disc;
	// Use this for initialization

	public override void OnStartHost() {
		disc.Initialize ();
		disc.StartAsServer ();
		NetworkServer.Reset ();
	}
	public override void OnStartClient(NetworkClient client){
		disc.showGUI = false;
	}
	public override void OnStopClient() {
		disc.StopBroadcast ();
		disc.showGUI = true;
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
