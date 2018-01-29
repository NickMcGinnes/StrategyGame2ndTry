using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CallFungus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Medical Ships Triggers
		if (Input.GetKeyDown (KeyCode.Q)) {

			//Med Distress
			Fungus.Flowchart.BroadcastFungusMessage ("Med");

		}

		if (Input.GetKeyDown (KeyCode.A)) {

			//Med Destroyed
			Fungus.Flowchart.BroadcastFungusMessage ("MedDed");

		}

		if (Input.GetKeyDown (KeyCode.S)) {

			//Med Survives
			Fungus.Flowchart.BroadcastFungusMessage ("MedSuv");

		}


		//Civilian Ship Triggers
		if (Input.GetKeyDown (KeyCode.E)) {


			Fungus.Flowchart.BroadcastFungusMessage ("Civ");

		}


		//Supply Ship Triggers
		if (Input.GetKeyDown (KeyCode.W)) {

			Fungus.Flowchart.BroadcastFungusMessage ("Supp");

		}

		if (Input.GetKeyDown (KeyCode.F)) {
			//Supplies Destroyed
			Fungus.Flowchart.BroadcastFungusMessage ("SupDed"); 
			//Supplies Escaped
			Fungus.Flowchart.BroadcastFungusMessage ("SupSuv");

		}





		//Fighter Ship Triggers
		if (Input.GetKeyDown (KeyCode.R)) {


			Fungus.Flowchart.BroadcastFungusMessage ("Fight");

		}


		if (Input.GetKeyDown(KeyCode.H))
		{

			Fungus.Flowchart.BroadcastFungusMessage("FightDed");
		}
	}
}
