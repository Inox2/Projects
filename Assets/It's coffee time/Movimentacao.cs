﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.D ) ) {
			transform.Translate(.2f,0,0);
		}

		if (Input.GetKey (KeyCode.A ) ) {
			transform.Translate(-.2f,0,0);
		}


}

}


