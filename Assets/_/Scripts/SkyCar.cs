using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyCar : MonoBehaviour {

	[SerializeField] int speed;
    [SerializeField] int speedRotation= 5;
    int marcha = 1;
    public Transform target;

	void Start () {

		speed = 10;
	}
	
	void Update () {

		transform.Translate(Vector3.forward * Time.deltaTime * speed *marcha);
        if (marcha == -1)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speedRotation);
        }
	}

	/*void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Target")
		{
			transform.position += Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
		}
	}*/

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "Pared")
		{
            marcha = marcha * -1;
		}
        if (collision.gameObject.tag == "Target")
        {
            //he encontrado el objetivo
            Debug.Log("Jorge.P ha encontrado el objetivo");
            marcha = 0;

        }

    }
}
