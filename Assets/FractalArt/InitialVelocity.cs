using UnityEngine;
using System.Collections;

public class InitialVelocity : MonoBehaviour
{
	// Use this for initialization
	void Start () {
		var initialForce = new Vector2(Random.Range(1f, 50f), Random.Range(1f, 50f));
		rigidbody2D.AddForce(initialForce);
	}
}
