using UnityEngine;
using System.Collections;

public class DialogManager : MonoBehaviour {

	
	public GameObject buttonPrefab;
	public int numberOfAnswer;
	public GameObject[] cloneButton = new GameObject[10];
	public Vector3 rootPoint = new Vector3(0,-10,0);
	public Vector3 highPoint = new Vector3 (0,-2,0);
	// Use this for initialization
	void Start () {
		for (int i = 0; i < numberOfAnswer; ++i){
				cloneButton[i] = (GameObject)Instantiate(buttonPrefab);
				//cloneButton[i].transform.position = rootPoint;
		}
		/* Rotation
		 	 if (numberOfAnswer%2 != 0){
			for (int i = 0; i< numberOfAnswer; ++i){
				cloneButton[i].transform.position = highPoint;
				if (i !=(numberOfAnswer-1)/2){
					cloneButton[i].transform.RotateAround( rootPoint, Vector3.forward, (float)((-9)*(numberOfAnswer-1)+18*(i)));
				}
			}
		}
		else{
			for (int i = 0; i< numberOfAnswer; ++i){
			//cloneButton[i].transform.position = new Vector3(5,-2,0);
			//cloneButton[i].transform.position = new Vector3(6,-3,0);
				cloneButton[i].transform.position = highPoint;
				cloneButton[i].transform.RotateAround( rootPoint, Vector3.forward, (float)((-9)*(numberOfAnswer-1)+18*(i)));
				}
			//cloneButton[i].transform.RotateAround( rootPoint, Vector3.forward, (float)(180*(i+1)/(numberOfAnswer+1)));
			}*/
		for (int i =0; i<numberOfAnswer;++i){
			cloneButton[i].transform.position = new Vector3(-5.8f+ (3*i),-3.8f);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
}
