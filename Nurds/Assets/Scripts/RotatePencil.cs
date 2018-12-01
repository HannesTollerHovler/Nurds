using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePencil : MonoBehaviour {
	public float speed;


	void Update () {
		float rotationSpeed = speed * Time.deltaTime;
		transform.Rotate(0,0,rotationSpeed);
	}
}
