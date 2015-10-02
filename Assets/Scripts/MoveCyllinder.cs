using UnityEngine;
using System.Collections;

public class MoveCyllinder : MonoBehaviour {

	public float speed = 1.0f;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		// transform.position = transform.position + new Vector3 (0.01f, 0.01f, 0.01f);
		Vector3 velocity = Vector3.back * speed;
		transform.position += velocity * Time.deltaTime;
		float timeSinceLastFrame = Time.deltaTime;
		// print (timeSinceLastFrame);
	}
}
