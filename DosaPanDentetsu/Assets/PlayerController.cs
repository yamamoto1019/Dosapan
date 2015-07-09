using UnityEngine;
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

	// Update is called once per frame
	void Update(){
		if (Input.GetMouseButtonDown(0)) {

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();

			if (Physics.Raycast(ray, out hit)){
				Vector3 hitStation = hit.collider.transform.position;
				if (hitStation == StationDatabase.station[0]) {
					NovelSingleton.StatusManager.callJoker("wide/station0","");
				}else if (hitStation == StationDatabase.station[1]){
					NovelSingleton.StatusManager.callJoker("wide/station1","");
				}else if (hitStation == StationDatabase.station[2]){
					NovelSingleton.StatusManager.callJoker("wide/station2","");
				}else if (hitStation == StationDatabase.station[3]){
					NovelSingleton.StatusManager.callJoker("wide/station3","");
				}else if (hitStation == StationDatabase.station[4]){
					NovelSingleton.StatusManager.callJoker("wide/station4","");
				}else if (hitStation == StationDatabase.station[5]){
					NovelSingleton.StatusManager.callJoker("wide/station5","");
				}else if (hitStation == StationDatabase.station[6]){
					NovelSingleton.StatusManager.callJoker("wide/station6","");
				}else if (hitStation == StationDatabase.station[7]){
					NovelSingleton.StatusManager.callJoker("wide/station7","");
				}else if (hitStation == StationDatabase.station[8]){
					NovelSingleton.StatusManager.callJoker("wide/station8","");
				}

			}
		}
	}
}