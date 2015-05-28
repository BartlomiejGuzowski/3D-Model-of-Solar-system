using UnityEngine;
using System.Collections;

public class Spaceship : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		GameObject[] Objects = GameObject.FindGameObjectsWithTag ("Object");
		//the gravity between each couple of object is calculated
		foreach (GameObject ObjectA in Objects)
		{
//			ObjectA.rigidbody.AddForce(new Vector3(50,0,100));
		}
	
	}
	void ApplyGravity(Rigidbody A, Rigidbody B)
	{
		
		//This is how to get the distance vector between two objects.
		Vector3 dist = B.transform.position - A.transform.position;
		float r = dist.magnitude;
		dist /= r;
		//This is the Newton's equation
		//G = 6.67 * 10^-11 N.m².kg^-2
		double G = 6.674f * (10 ^ 11);
		float force = ((float)G * A.mass * B.mass) / (r * r);
		//Then, just apply the forces
		A.AddForce (dist * force);
		B.AddForce (-dist * force);
	}

	// Update is called once per frame
	void Update () {
		//Get every object
		GameObject[] Objects = GameObject.FindGameObjectsWithTag ("Object");
		//the gravity between each couple of object is calculated
		foreach (GameObject ObjectA in Objects)
		{
			foreach (GameObject ObjectB in Objects)
			{
				//Objects must not self interact
				if(ObjectA == ObjectB)
					continue;
				ApplyGravity(ObjectA.GetComponent<Rigidbody>(), ObjectB.GetComponent<Rigidbody>());
				//	if(ObjectA.rigidbody.position == ObjectB.rigidbody.position){
				//ObjectA.rigidbody.animation.
			}
			
		}

	
	}
}
