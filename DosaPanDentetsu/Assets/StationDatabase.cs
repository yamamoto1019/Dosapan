using UnityEngine;
using System.Collections;

public class StationDatabase : MonoBehaviour {
	
	private int i;
	public GameObject Station;

	public static Vector3[] station = new Vector3[9];

	void Awake(){

		//station manager
		Station = Resources.Load ("Prefabs/Station") as GameObject;

		station[0] = new Vector3 ( 73.5f, 12.5f,  66.5f); //Hakodate
		station[1] = new Vector3 ( 63.0f, 12.5f,  73.5f); //Onumakoen
		station[2] = new Vector3 ( 50.0f, 12.5f,  82.0f); //Yakumo
		station[3] = new Vector3 ( 47.5f, 12.5f, 101.0f); //Osyamanbe
		station[4] = new Vector3 ( 63.0f, 12.5f, 110.5f);
		station[5] = new Vector3 ( 77.5f, 12.5f,  95.0f); //Muroran
		station[6] = new Vector3 (103.0f, 12.5f, 111.0f); //Tomakomai
		station[7] = new Vector3 (101.5f, 12.5f, 122.0f); //Titose
		station[8] = new Vector3 ( 90.0f, 12.5f, 130.0f); //Sapporo

		for(i=0; i<9; i++)
			Instantiate(Station, station[i], Quaternion.identity);

	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
}
