using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomShirtColor : MonoBehaviour {

	public SpriteRenderer body;
	public Color[] color;

	void Awake(){
		int maxIndex = color.Length;
		int randomIndex = Random.Range(0, maxIndex);
		body.color = color[randomIndex];

	}
}
