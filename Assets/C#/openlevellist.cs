using UnityEngine;
using UnityEngine.SceneManagement;
public class openlevellist : MonoBehaviour {
	public GameObject Levelpanal;
	public void open(){
		Levelpanal.SetActive (true);
	}
	public void openlevels (int levelnum) {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+levelnum);
	}
}
