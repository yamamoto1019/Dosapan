using UnityEngine;
using System.Collections;

public class RacketController : MonoBehaviour {

	private float accel = 1000.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().AddForce (transform.right * Input.GetAxisRaw ("Horizontal") * accel, ForceMode.Impulse);
	}
}
