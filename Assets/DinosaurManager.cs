﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurManager : MonoBehaviour {

	public Animation anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		anim.Play ("Scream");
	}
}
