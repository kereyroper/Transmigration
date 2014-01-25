using UnityEngine;
using System.Collections;

public class MemoryManager : MonoBehaviour
{
	private PlayerState playerState;

	// Use this for initialization
	void Start () {
		var globals = GameObject.Find("Globals");
		playerState = globals.GetComponent<PlayerState>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
