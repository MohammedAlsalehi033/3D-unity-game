using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour {
	public void ST() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
	public void QT(){
		Application.Quit();
	}
	public void FM(){
		Application.OpenURL ("www.google.com");
	}
}
