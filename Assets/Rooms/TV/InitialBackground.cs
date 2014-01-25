using UnityEngine;
using System.Collections;

public class InitialBackground : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var spritePrefab = Resources.Load<Sprite>("tvStart01");
		var sprite = (Sprite)Instantiate(spritePrefab);
		var spriteRender = gameObject.GetComponent<SpriteRenderer>();
		spriteRender.sprite = sprite;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
