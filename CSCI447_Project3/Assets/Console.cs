using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour {

	public bool nextToConsole;
	public GameObject orb;

	void Start(){
		nextToConsole = false;
		orb.SetActive(false);
	}

	void Update(){
		if (nextToConsole == true && Input.GetKeyDown (KeyCode.E))
			orb.SetActive(true);
			
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player")
			nextToConsole = true;
	}

	void OnTriggerExit(Collider other){
		nextToConsole = false;
	}
}
