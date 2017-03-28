using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExitController : MonoBehaviour {

	public Transform[] platformPrefabs;

	int num;

	// Use this for initialization
	void Start () {
		num = Random.Range(0, 4);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			Vector3 nextPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 10);
			Instantiate (platformPrefabs[num], nextPosition, Quaternion.identity); 
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Player") {
			Destroy (transform.parent.gameObject);
		}
	}
}
