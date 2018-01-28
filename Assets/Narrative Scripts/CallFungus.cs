using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CallFungus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {


			Fungus.Flowchart.BroadcastFungusMessage ("Med");

		}

		if (Input.GetKeyDown (KeyCode.E)) {


			Fungus.Flowchart.BroadcastFungusMessage ("Civ");

		}

		if (Input.GetKeyDown (KeyCode.W)) {

			Fungus.Flowchart.BroadcastFungusMessage ("Supp");

		}

		if (Input.GetKeyDown (KeyCode.R)) {


			Fungus.Flowchart.BroadcastFungusMessage ("Fight");

		}
	}
}
