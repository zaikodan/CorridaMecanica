using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casa : MonoBehaviour {
	[Range(1, 7)]
	public int numero;

	void Start () {
		numero = Random.Range(0, 7);
	}
}
