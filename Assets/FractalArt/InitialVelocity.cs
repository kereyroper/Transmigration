using UnityEngine;
using System.Collections;

public class InitialVelocity : MonoBehaviour
{
	public Vector2 initialForce;

	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce(initialForce);
	}
}
