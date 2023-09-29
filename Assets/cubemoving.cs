using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemoving : MonoBehaviour {
	public Rigidbody cd;
	public int j;
	public int x;
	public int k;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		cd.AddForce (j, x, k);
		cd.AddRelativeTorque (j, x, k);
	}
}
