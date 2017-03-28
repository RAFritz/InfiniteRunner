using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	float time;

	public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time = Time.timeSinceLevelLoad;
		if (time >= 30 && !player.gameObject.GetComponent<PlayerController>().isDead )
			SceneManager.LoadScene ("Scene2");
	}
}
