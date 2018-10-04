using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyCar : MonoBehaviour {

	[SerializeField] int speed;
	public Transform target;

	void Start () {

		speed = 10;
	}
	
	void Update () {

		transform.position += Vector3.forward * Time.deltaTime * speed;
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Target")
		{
			transform.position += Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
		}
	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "Target")
		{
			speed = 0;
		}
	}
}
