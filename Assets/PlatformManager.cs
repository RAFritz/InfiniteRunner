using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour {

	public Transform platformPrefab;

	Vector3 startPosition = Vector3.zero;

	// Use this for initialization
	void Start () {
		Instantiate (platformPrefab, startPosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
}
