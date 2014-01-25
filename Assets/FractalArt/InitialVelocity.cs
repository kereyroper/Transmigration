using UnityEngine;
using System.Collections;

public class InitialVelocity : MonoBehaviour
{
	public Vector2 initialForce;
	public Rigidbody2D rigidbody2D;

	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce(initialForce);
	}
}
