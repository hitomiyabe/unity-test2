﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Goal2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Player") {
			SceneManager.LoadScene ("Goal2");
		}
	}
}