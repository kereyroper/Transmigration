using UnityEngine;
using System.Collections;
using SimpleJSON;

public class StoryManager : MonoBehaviour
{
	public TextAsset storyJsonFile;

	// Use this for initialization
	void Start () {
		var storyJson = JSONNode.Parse(storyJsonFile.text);
		Debug.Log(storyJson["storyElements"][0]["prompt"]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
