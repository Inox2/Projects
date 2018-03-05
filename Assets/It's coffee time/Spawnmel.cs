using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmel : MonoBehaviour {

		public float timer;
		public GameObject _mel;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {
			timer += Time.deltaTime;

			if (timer >= 2.5f) {
				SpawnObject ();
				timer = 0;

			}
		}


		void SpawnObject(){
			Instantiate(_mel, this.gameObject.transform.position, Quaternion.identity);
		}
	}

	
