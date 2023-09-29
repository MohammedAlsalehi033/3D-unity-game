using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {
	public Transform playerposison;
	public Transform dont_fil;
	public bool endornot;
	// Update is called once per frame
	public	void Update () {
		if (endornot == true || playerposison.position.y < 3f) {
			Invoke ("rp", 0.5f);
		} else if (dont_fil.position.y <= 6) {
			Invoke ("rp", 0.5f);
		}
	}

	void rp(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);	
	}}

