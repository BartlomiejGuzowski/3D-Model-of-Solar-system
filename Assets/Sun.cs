using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour {
	GameObject spaceship;
	public GameObject Other;
	public Color c1 = Color.yellow;
	public Color c2 = Color.red;
	// Use this for initialization
	public Vector3 SpaceShipForce ;
	public int lengthOfLineRenderer = 25;
	public float ConstantG;
	public int X;
	public int Y;
	public int Z;
	public Vector3 Position;
	Vector3 saveZone;
	public Material Element;
	public Vector3 Velecity; 
	//PathPredyction path = new PathPredyction ();
//	planet Planet = new planet();
	float  timeplus = 0.1f;
	float ReallyTime = 2.5f;
	float f = 0.02f;
	void Start () {

		//LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
	//	lineRenderer.material = Element;
	//	lineRenderer.SetColors(c1, c2);
	//	lineRenderer.SetWidth(0.2F, 0.2F);
	//	lineRenderer.SetVertexCount(lengthOfLineRenderer);





		Time.fixedDeltaTime = 1.0f;
		transform.GetComponent<Rigidbody>().mass = 40;
		saveZone = new Vector3 (10, 10, 10);
		GameObject[] Objects = GameObject.FindGameObjectsWithTag ("Object");
		spaceship = GameObject.FindWithTag("Spaceship");
		//the gravity between each couple of object is calculated
		foreach (GameObject ObjectA in Objects)
		{
		//	ObjectA.rigidbody.AddForce(new Vector3(0,0,100));


		}
	//	ApplyGravity (transform.rigidbody, Other.rigidbody);
	//	path.Predition (force,Velecity(10,0,0));
	//	spaceship.rigidbody.AddForce (new Vector3 (X,Y,Z));
	}


/*	void PredictOrbit(Vector3 startpos, Vector3 velocity, float gravity){

		int verts = 20;
		LineRenderer line; //= gameObject.GetComponent<LineRenderer>;

		line.SetVertexCount (verts);

		Vector3 pos = startpos;
		Vector3 vel = velocity;
		float force = gravity;

		for (int i = 0; i< verts; i++) {
			line.SetPosition(i,new Vector3(pos.x,pos.y,0));
			vel = vel + force * Time.fixedDeltaTime;
			pos = pos + force * Time.fixedDeltaTime;

		}
	
	}*/
	
	/*
	void Predition(float force , Vector3 velocity){
				LineRenderer orbit = gameObject.AddComponent<LineRenderer> (); 
				Vector3 pos = Other.transform.position;
				int count = 30;
				for (var i = 0; i < count; i++) {
						orbit.SetPosition (i, pos);
						velocity.x = + force * Time.fixedDeltaTime;
						pos += velocity * Time.fixedDeltaTime;  
				}
		}*/
	void ApplyGravity(Rigidbody A, Rigidbody B)
	{
					//This is how to get the distance vector between two objects.
				Vector3 dist = B.transform.position - A.transform.position;
				float r = dist.magnitude;
				dist /= r;
				//This is the Newton's equation
				//G = 6.67 * 10^-11 N.m².kg^-2
				double G = ConstantG * (10 ^ 11);
				 float force = ((float)G * A.mass * B.mass) / (r * r);
				//Then, just apply the forces
		        A.AddForce (dist * force);
	  			B.AddForce (-dist * force);
		//Vector3 pos = dist * force;
	//	Time.timeScale = 1.5f;
	//	Position = ((dist*force)*Time.timeScale); //+ new Vector3(pos.x+1,pos.y,pos.z+1);
	//	//A.AddForce (pos);
	//	Predition (force, A.velocity);
		//B.velocity = new Vector3(120,0,0);
	//	path.Predition (force, B.velocity);
	//	PredictOrbit (B.position,B.velocity,force);
	
		if (B.position.magnitude <= A.position.magnitude  ){//&& A.position.x <= B.position.x -10 ) {
	//		Debug.Log ("Pos of A"+A.position);
	//		Debug.Log ("Pos of B"+B.position);
//DestroyObject(B);
			//Destroy(B);
		//	B.transform.position = new Vector3(500,500,500);
		}

	}
	
	// Update is called once per frame
	void Update () {
	//	if (Input.GetKeyDown (KeyCode.S)) {
	//					Time.timeScale = 2.0f;		
	//			}
	//	Debug.Log (Planet.Runs);
		//if(Planet.Runs){

//		LineRenderer lineRenderer = GetComponent<LineRenderer>();
//		int i = 0;
//		while (i < lengthOfLineRenderer) {
	// Vector3 pos = new Vector3(i * 0.5F, Mathf.Sin(i + Time.time), 0);
//			Vector3 pos; 
			//	Vector3 pos = transform.position ;

//			lineRenderer.SetPosition(i,Position);
//			i++;
//		}
	//	Debug.Log (Position + "      " + transform.position);
						//	Debug.Log("Universe Runs");
						GameObject[] Objects = GameObject.FindGameObjectsWithTag ("Object");
						GameObject spaceship = GameObject.FindWithTag ("Spaceship");
						//}
						//the gravity between each couple of object is calculated
						//	foreach (GameObject ObjectA in Objects)
						//	{
						foreach (GameObject ObjectB in Objects) {
							//	if (ObjectB.rigidbody != null) {
			
					
										//Objects must not self interact
										if (transform == ObjectB)
												continue;
										ApplyGravity (transform.GetComponent<Rigidbody>(), ObjectB.GetComponent<Rigidbody>());
					
							//	}
								//else 
								//	break;
								//	if(ObjectA.rigidbody.position == ObjectB.rigidbody.position){
								//ObjectA.rigidbody.animation.
						}
			
						//		}
						if (Input.GetKeyDown (KeyCode.RightArrow)) {
								//	Time.timeScale = ReallyTime;
								//timeplus ++;
								Time.timeScale = Time.timeScale + timeplus;
						}
						if (Input.GetKeyDown (KeyCode.LeftArrow)) {
								//	Time.timeScale -= timeplus;
								//	timeplus --;
								//  if(Time.timeScale < 0){
								Time.timeScale = Time.timeScale - timeplus;
								//	}
						}
						Time.fixedDeltaTime = f * Time.timeScale;
				



			//Get every object
		
				} 
	//else {
	//		Time.fixedDeltaTime = 0.0f;	
		//	Debug.Log("Universe stop");
	//	}
	//}
/*
	void UpdatePosition(){

	}
*/
	/*
	void FixedUpdate ()
	{
		//Get every object
		Objects = GameObject.FindGameObjectsWithTag ("Object");
		
		//the gravity between each couple of object is calculated
		foreach (GameObject ObjectA in Objects)
		{
			foreach (GameObject ObjectB in Objects)
			{
				//Objects must not self interact
				if(ObjectA == ObjectB)
					continue;
				
				ApplyGravity(ObjectA.rigidbody, ObjectB.rigidbody);
			}
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
		float force = ((float)G * A.mass * B.mass) / (r * r);
		
		//Then, just apply the forces
		A.AddForce (dist * force);
		B.AddForce (-dist * force);
	}
*/
}
