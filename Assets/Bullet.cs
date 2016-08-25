﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		ProcessObject processObject = collision.gameObject.GetComponent<ProcessObject> ();
		if (processObject != null) {
			Debug.Log("Kill "+processObject.getProcess().Id);
			processObject.getProcess().Kill ();
			GameObject.Find ("ProcessManager").GetComponent<ProcessManager>().UpdateProcesses();
		}
	}
}