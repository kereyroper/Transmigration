using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
	public float triggerTime;
	public GameEvent gameEvent;

	public float relativeTime;

	// Use this for initialization
	void Start () {
		relativeTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		relativeTime += Time.deltaTime;
		if (relativeTime >= triggerTime) {
			gameEvent.Trigger();
		}
	}
}
