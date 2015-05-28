using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	bool pause =false; 
	CreateNewPlanet newplanet = new CreateNewPlanet();
	void OnGui(){
	
		//	Debug.Log("MENU!!!!");
		if (Input.GetKeyDown(KeyCode.P)) {
			Debug.Log("MEnu work");
			GUI.Label(new Rect (25, 25, 100, 30), "Pause");
			newplanet.CreateNePlanet(new Vector3 (15,0,20),5.0f,new Vector3(1,1,1),"Mars");
			pause = true;
			Time.timeScale = 0.0f;

		//	GUI.Label(new Rect (25, 25, 100, 30), "Pause");
   			Debug.Log("MEnu work");	
		}
		if (Input.GetKeyDown (KeyCode.R)){//&& pause==true) {
			Debug.Log("Resume work");			
			Time.timeScale = 1.0f;
						pause = false;
				}
	//	if (GUI.Button (new Rect (25, 25, 100, 30), "Menu")) {
	//		Debug.Log("MEnu work");	
	//	}
	}

	// Use this for initialization
	void Start () {
	//	OnGui ();
	}
	
	// Update is called once per frame
	void Update () {
		OnGui ();
	}
}
