using UnityEngine;
using System.Collections;

public class InitializeDay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad(GameObject.Find("DayGlobals"));
		Application.LoadLevel("Living");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
