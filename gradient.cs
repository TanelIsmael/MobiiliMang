﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gradient : MonoBehaviour {

	public Gradient myGradient;
	public float strobeDuration = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float t = Mathf.PingPong(Time.time / strobeDuration, 1f);
		Camera.main.backgroundColor = myGradient.Evaluate(t);
	}
}
