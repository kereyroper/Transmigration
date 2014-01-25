using UnityEngine;
using System.Collections;

public class YellowButton : MonoBehaviour {

	public Texture dialogBox;
	public Rect position;

	// Use this for initialization
	void Start () {
	
	}

	// Use this for initialization
	void OnGUI(){
		if (!dialogBox){
			Debug.LogError("Need Texture for the Button");
			return;
		}
		else {
			//clicked on the button
			Debug.Log("Clicked the Respond");
			}
	}
	// Update is called once per frame
	void Update () {
	
	}

	void respond(){

	}
}
