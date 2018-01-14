using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof (CapsuleCollider))]
public class PositionResetter : MonoBehaviour {
	public Vector3 startPosition;
	// Use this for initialization
	void Start () {

	}

	void OnCollisionEnter (Collision col){
		if(col.gameObject.tag == "Player"){
			col.gameObject.transform.position = startPosition;
			col.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
		}
	}
}
