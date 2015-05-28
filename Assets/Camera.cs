using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
 public	float MaxZoom = 15f;
 public	float MinZoom = 100f;
	float sens = 10f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
//		while (Input.GetKeyDown(KeyCode.DownArrow)) {
//			Vector3 position = this.transform.position;
//			position.y++;
//			this.transform.position = position;
//		}

		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Vector3 position = this.transform.position;
			position.y++;
			this.transform.position = position;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			Vector3 position = this.transform.position;
			position.y--;
			this.transform.position = position;
		}


		}
}

