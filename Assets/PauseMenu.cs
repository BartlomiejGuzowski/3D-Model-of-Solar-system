using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	bool IsGamePause = false ;
	// Use this for initialization
	void Start () {
		OnGUI ();
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetButtonDown("pauseButton")) {
			IsGamePause = PauseFunction();		
		}

	}
	void OnGUI()
	{
		if (IsGamePause) {
			GUILayout.Label("Pause");
			if(GUILayout.Button("Pause The game"));
			   IsGamePause = PauseFunction();
		}
	}
			   bool PauseFunction(){
				if (Time.timeScale == 0f) {
						Time.timeScale = 1f;
						return (false);
				} else {
					Time.timeScale = 0f;
					return(true);
				}
			}

}
