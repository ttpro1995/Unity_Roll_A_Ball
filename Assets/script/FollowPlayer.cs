using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public GameObject player; // public so we can select object in inspector mode
	Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = player.transform.position - transform.position;
		// <=> transform.position = player.transform.position - offset 

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate(){
		transform.position = player.transform.position - offset;
		// transform from the equation above
	}
}
