using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public float timer;
	public GameObject _sugar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (timer >= 1f) {
			SpawnObject ();
			timer = 0;

		}
	}


	void SpawnObject(){
		Instantiate(_sugar, this.gameObject.transform.position, Quaternion.identity);
	}
}