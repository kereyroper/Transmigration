using UnityEngine;
using System.Collections;

public class MemoryManager : MonoBehaviour
{
	public GameObject[] spriteGos;
	public GameObject spriteGoPrefab;
	private PlayerState playerState;

	// Use this for initialization
	void Start () {
		var globals = GameObject.Find("Globals");
		playerState = globals.GetComponent<PlayerState>();
		var spritePrefab = Resources.Load<Sprite>("tv01");
		var sprite = (Sprite)Instantiate(spritePrefab);
		spriteGos = new GameObject[10];
		var spriteGo = (GameObject)Instantiate(spriteGoPrefab);
		spriteGo.GetComponent<SpriteRenderer>().sprite = sprite;
		spriteGos[0] = spriteGo;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
