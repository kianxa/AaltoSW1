using UnityEngine;
using System.Collections;

public class MoveArms : MonoBehaviour {

	public float moveX;
	public float moveY;
	public float moveZ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Vector3 rotation1 = new Vector3(moveX, 0f, 0f);
		transform.Rotate (moveX, moveY, moveZ); 

	
	}
}
