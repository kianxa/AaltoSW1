using UnityEngine;
using System.Collections;

public class LogMan : MonoBehaviour {
	
	public int number1 = 1;
	public int number2 = 2;

	// Use this for initialization
	void Start () {
		// print ("Printttaa!");
		// Debug.Log ("Debuggaa!");
		int number_1 = 5;
		int number_2 = 9000;
		int result = number_1 - number_2;
		string manowar = "Powerlevel: ";
		
		print (manowar + result);
		/*
		double myDouble = 30.12321355334499;
		float myFloat = 60.42332923211832f;
		print (myFloat);
		print (myDouble); //double on tarkempi
		*/ 
		bool numberTest = 5 > 9;
		// print (numberTest); 

		if (numberTest){ 
			print ("5 is larger than 9");
		}
		if (! numberTest){ 
			print ("5 is not larger than 9");
		}

		if (numberTest) { 
			print ("IF is true");
		}
		else { 
			print ("IF is NOT true");
		}


		if (number1 < number2) { 
			print ("number1 is smaller than number2");
		}
		else if (number1 > number2){ 
			print ("number2 is smaller than number1");
		} 
		else { 
			print ("number1 is equal to number2");
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
