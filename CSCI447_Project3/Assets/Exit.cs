using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

	public int orbCount;
	public GameObject door;
	public static Exit instance;

	void Start() {
		instance = this;
	}

	// Update is called once per frame
	void Update () {
		if (orbCount == 3)
			door.SetActive (false);
	}
}
