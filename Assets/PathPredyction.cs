using UnityEngine;
using System.Collections;

public class PathPredyction : MonoBehaviour {




	public void Predition(float force , Vector3 velocity){
		LineRenderer orbit = gameObject.AddComponent<LineRenderer>(); 
		Vector3	pos = transform.position;
		int count= 30;
		for (var i = 0; i < count; i++) {
			orbit.SetPosition(i, pos);
			velocity.x =+ force * Time.fixedDeltaTime;
			pos += velocity * Time.fixedDeltaTime;  
		}

	}

	// Use this for initialization
	void Start () {
		LineRenderer orbit = gameObject.AddComponent<LineRenderer>(); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
