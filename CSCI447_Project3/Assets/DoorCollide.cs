using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollide : MonoBehaviour {

	public int level;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player")
			Application.LoadLevel (level);
	}
}
