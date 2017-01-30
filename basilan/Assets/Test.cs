using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class Test : NetworkBehaviour {
	public LocalPlayer player;
	// Use this for initialization
	void Start () {
		
	}
	public void Spawn() {
		
	player.GetComponent<LocalPlayer> ().RpcChange ();


			player.GetComponent<LocalPlayer> ().CmdChange1 ();

		
	}
	public void Spawn1() {
		player.GetComponent<LocalPlayer> ().RpcChange2 ();	
	
			player.GetComponent<LocalPlayer> ().CmdChange2 ();

	}
	public void Spawn2() {
		player.GetComponent<LocalPlayer> ().RpcChange3 ();	
	
			player.GetComponent<LocalPlayer> ().CmdChange3 ();

	}
	public void Spawn3() {
		player.GetComponent<LocalPlayer> ().RpcChange4 ();	


			player.GetComponent<LocalPlayer> ().CmdChange4 ();
		
	}


	// Update is called once per frame
	void Update () {
		
	}
}
