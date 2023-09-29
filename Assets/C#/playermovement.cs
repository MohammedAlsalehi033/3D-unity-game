using UnityEngine;
public class playermovement : MonoBehaviour {
		public Rigidbody rd;
		public int j;
		public int x;
		public int k;
		// Update is called once per frame
		void FixedUpdate () {
             if(Input.GetKey("s")){
			rd.AddForce(0,0,-k*Time.deltaTime);
			}
			if(Input.GetKey("d")){
			rd.AddForce(x*Time.deltaTime,0,0);
			}
			if(Input.GetKey("w")){
			rd.AddForce(0,0,k*Time.deltaTime);
			}
			if(Input.GetKey("a")){
			rd.AddForce(-x*Time.deltaTime,0,0);
			}
			if(Input.GetKey("space")){
			rd.AddRelativeTorque(0,j*Time.deltaTime,0);
			}

                       		}
	}


