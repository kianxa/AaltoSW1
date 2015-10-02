using UnityEngine;
using System.Collections;

public class ColourClick : MonoBehaviour {

	private Color[] colors = {Color.blue, Color.red, Color.magenta};
	private Color lerpedColor = Color.white;


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		int indexa = Random.Range(0, (colors.Length - 1));

		lerpedColor = Color.Lerp(lerpedColor, Color.black, 0.01f);
		
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast(ray, out hit)){
			hit.collider.GetComponent <Renderer>().material.color = lerpedColor;

		//	hit.collider.GetComponent <Renderer>().material.color = colors[indexa];
		}
	
	}
}
