using UnityEngine;
using System.Collections;

public class MakeGlobal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
	}
	
}
