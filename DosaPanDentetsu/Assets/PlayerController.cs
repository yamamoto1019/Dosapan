using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	private int i;
	public float Sec = 100f;
	public float obj = 0;

	// Use this for initialization
	void Start () {
		i = 0;
		transform.position = StationDatabase.station[i];
	}
	
	// Update is called once per frame
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
}