using UnityEngine;
using System.Collections;

public class YellowButtonBehaviour : MonoBehaviour {

	public SpriteRenderer ButtonSprite;

	//public SpriteRenderer ButtonTexture;

	// Use this for initialization
	void Start () {
		//ButtonSprite.sprite = (Sprite)Instantiate(Resources.Load<Sprite>("PinTemp"));
		ButtonSprite.sprite = (Sprite)Instantiate(Resources.Load<Sprite>("TestMess"));
		//Instantiate ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		Debug.Log("Clicked.");
	}
}
