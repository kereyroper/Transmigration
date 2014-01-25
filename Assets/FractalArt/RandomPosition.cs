using UnityEngine;
using System.Collections;

public class RandomPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.transform.position = new Vector3(Random.Range(-6f, 6f), Random.Range(-4f, 4f), 0);
	}
}
