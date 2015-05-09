using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate ((new Vector3 (30, 45, 30))// vector3, the vector how much the object is rotate
		                  * Time.deltaTime // make the rotation independent to frame rate 
		                  );
	}
}
