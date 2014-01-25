using UnityEngine;
using System.Collections;

public class ClickHandler : MonoBehaviour
{
	public string scene;

	void OnMouseDown() {
		Application.LoadLevel(scene);
	}
}
