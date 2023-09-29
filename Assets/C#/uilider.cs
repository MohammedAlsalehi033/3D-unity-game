using UnityEngine.UI;
using UnityEngine;

public class uilider : MonoBehaviour {
	public int lavelnumb;
	public GameObject pan;
	public Button[] Levels = new Button [10];

	void Start(){
		lavelnumb = PlayerPrefs.GetInt ("id");
	}
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < lavelnumb+1; i++) {
			Levels [i].interactable = true;
		}
	}
	public void sm(){

		pan.SetActive (true);
	}
}
