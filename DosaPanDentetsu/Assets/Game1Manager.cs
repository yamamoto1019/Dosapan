using UnityEngine;
using System.Collections;

public class Game1Manager : MonoBehaviour {

	public bool game1End = false;
	public GameObject block;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		block = GameObject.Find ("Block");
		if (block == null) {
			Application.LoadLevel("Main");
		}
	}
}
