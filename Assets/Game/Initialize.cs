using UnityEngine;
using System.Collections;

public class Initialize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (!GameObject.Find("Globals")) {
			Application.LoadLevel("InitializeGlobals");
		} else {
			var dayGlobals = GameObject.Find("DayGlobals");
			if (dayGlobals != null) {
				Destroy(dayGlobals);
			}
			Application.LoadLevel("InitializeDay");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
