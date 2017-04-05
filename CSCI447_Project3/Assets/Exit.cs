using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

	public int orbCount;
	public GameObject door;

	void Start() {
		
	}

	// Update is called once per frame
	void Update () {
		if (orbCount == 3)
			door.SetActive (false);
	}

	public void UdpateCount(){
		orbCount += 1;
	}
}
