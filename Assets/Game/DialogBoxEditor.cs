using UnityEngine;
using System.Collections;
using UnityEditor;

public abstract class DialogBoxEditor : MonoBehaviour {

	public int width, height, content;
	private abstract void updateSize();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if width, height or content changed
		//updateSize()
	}

	void updateSize(){
		//dialogWidth = current width
		//dialogHeight = current height
	}
}
