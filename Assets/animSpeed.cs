using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animSpeed : MonoBehaviour {

	public float speed=0.5f;

	void Start(){
		GetComponent<Animator> ().speed = speed;
	}

}
