using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	private float speed = 20.0f;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().AddForce (-(transform.forward + transform.right) * speed, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
