using UnityEngine;
using System.Collections;

public class ColliderAdder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.AddComponent<PolygonCollider2D>();
	}
}
