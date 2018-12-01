using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnLane : MonoBehaviour {

	public float speed;
	
	void Update(){
		float movement = speed * Time.deltaTime;
		transform.Translate(movement,0,0);
		Debug.Log (Time.deltaTime);
	}

}
