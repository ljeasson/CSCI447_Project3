using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToHub : MonoBehaviour {

	public GameObject exit;
	public int count;

	void Start () {
		count = exit.GetComponent<Exit> ().orbCount;
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Application.LoadLevel (0);
			count += 1;
		}
	}

}
