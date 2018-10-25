using UnityEngine;
using System.Collections;

public class TurnOnCollision : MonoBehaviour 
{
	public float speed;
	
	void Start()
	{
		//start going in a random direction.
		GetComponent<Rigidbody>().velocity = new Vector3(Random.Range (-1f,1f),0,Random.Range(-1f,1f)) * speed;	
	}
	
	//Fixed Update is called once per physics frame
	void FixedUpdate () 
	{
		//face the direction we are moving.
		transform.rotation = Quaternion.LookRotation(GetComponent<Rigidbody>().velocity);
	}
	
	void OnCollisionEnter(Collision other)
	{
		//pick a new direction using a central circle of 10 radius. Ships will have a central tendancy this way.
		GetComponent<Rigidbody>().velocity = (new Vector3(Random.Range (-10f,10f),0,Random.Range(-10f,10f)) - transform.position);

		//make sure we don't go beyond our max speed in the new direction.
		GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * speed;
	}
}
