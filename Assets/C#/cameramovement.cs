using UnityEngine;
public class cameramovement : MonoBehaviour {
	public Transform player;
	public Transform cam1era;
	public Vector3 thefarbetwenthem;
	void FixedUpdate () {
		cam1era.position = player.position - thefarbetwenthem ;
	}
}
