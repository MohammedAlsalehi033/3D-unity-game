using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rota : MonoBehaviour {
	public Rigidbody Coin;
	public int j;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Coin.AddRelativeTorque (0, j * Time.deltaTime, 0);
	}
}
