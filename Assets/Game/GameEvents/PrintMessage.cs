using UnityEngine;
using System.Collections;

public class PrintMessage : GameEvent
{

	public string message;

	void OnGUI() {
		GUI.Label(new Rect(0f,0f,100f,100f), message);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void Trigger() {
		message = "triggered";
		// logic is in OnGUI, don't need anthing here
	}
}
