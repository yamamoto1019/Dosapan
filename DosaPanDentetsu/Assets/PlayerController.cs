﻿using UnityEngine;
using System.Collections;
using Novel;

public class PlayerController : MonoBehaviour {
	
	private int i;
	public float Sec = 100f;
	public float obj = 0;

	// Use this for initialization
	void Start () {
		i = 0;
		transform.position = StationDatabase.station[i];
	}
	
	void FixedUpdate () {
		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			if (i >= 0 && i < 8) {
				i=i+1;
			}
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			if (i > 0 && i < 9) {
				i = i - 1;
			}
		}
		transform.position = transform.position + Vector3.Scale(StationDatabase.station[i] - transform.position, new Vector3(obj, obj, obj));
		obj += Time.deltaTime / Sec;

	}

	// Update is called once per frame
	void Update(){
		if (Input.GetKey(KeyCode.Space)) {
			NovelSingleton.StatusManager.callJoker("wide/scene0","");
		}
	}
}