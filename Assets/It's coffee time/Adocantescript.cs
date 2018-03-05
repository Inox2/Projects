using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adocantescript : MonoBehaviour {
	public Score Score_score;
	public int pontos;
	// Use this for initialization
	void Start () {
		Score_score = GameObject.Find ("System").GetComponent<Score> ();

	}

	// Update is called once per frame
	void Update () {}
	void OnTriggerEnter2D(Collider2D col ) {
		if (col.tag == "Player" ) { 
			Score_score.scorecoffee += pontos;
			Destroy(this.gameObject ) ;
		} 
	}

	void OnBecameInvisible () { 
		Destroy (this.gameObject);
	}
}