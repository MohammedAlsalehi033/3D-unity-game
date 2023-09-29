using UnityEngine;
using UnityEngine.SceneManagement;
public class playerboom : MonoBehaviour {
	public playermovement bo2ol;
	public gameover gameover2;
	public int levid;
	public GameObject ex;
	public Transform player;

	public GameObject completlavel;
	void OnCollisionEnter (Collision ded) {
		if (ded.collider.tag == "ex") {
			player.transform.localScale/=3;
			Destroy (ex);
		}
		else if (ded.collider.tag == "diedcube") {
			bo2ol.enabled = false;
			gameover2.endornot = true;

		} else if (ded.collider.name == "finshing") {
			completlavel.SetActive (true);
			Invoke ("NL", 2f);
			if (levid >= PlayerPrefs.GetInt ("id")) {
				PlayerPrefs.SetInt ("id", levid);
				Debug.Log (PlayerPrefs.GetInt ("id"));
			}
		}
	}
	public void NL(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

	
	}}