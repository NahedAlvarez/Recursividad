using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonaccio : MonoBehaviour {

	public int number;

	// Use this for initialization
	void Start() {
		Nabuconodosor(number);
	}
	int index = 0;
	int n1 = 1, n2 = 1;

	private void Nabuconodosor(int n)
	{
		if (n <= index)
		{
			Debug.Log("Finalizo el proceso");
			index = 0;
			return;
		}
		else
		{
			if (index >= 2)
			{				
				n1 = n2 + n1;
				n2 = n1 - n2;
				Debug.Log(n1);
			}
			else
			{
				Debug.Log(n1);
			}			
			index++;
			//Debug.Log(index);
			Nabuconodosor(n);			
		}
	}
}
