using UnityEngine;
using System.Collections;

public class ArrayAndLoop : MonoBehaviour {

	public int[] finishOrder;

	// Use this for initialization
	void Start () {
		// finishOrder = new Int[] {3, 6, 1, 2, 4, 5};
		// print (finishOrder[0]);

		int i = 0;
		while (i < finishOrder.Length) {
			print (finishOrder [i]);
			i = i + 1;
		}

		for (int j=0; j < finishOrder.Length; j = j+1) {
			print (finishOrder[j]);
		}

		foreach (int j in finishOrder) {

		}

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
