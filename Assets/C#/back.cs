using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class back : MonoBehaviour {
	public int times=10;
	public GameObject ft ;
	public cubemoving cd;
	void Update () {
		
		if (PlayerPrefs.GetInt ("ft") == 1) {
			ft.SetActive (false);
			Debug.Log ("2");
		}
	}
	public void endamna1(GameObject w2){
		w2.SetActive (false);
	}
	public void bk(GameObject pan){
		pan.SetActive (true);
	}
	public void bk2 (GameObject pan)
	{
		pan.SetActive (false);
	}
	public void retgame(){
		SceneManager.LoadScene(sceneName:"mainmino"); 
	}
	public void retlevel (GameObject pan)
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		pan.SetActive (false);
	}
	public void help_show_things(GameObject hlp){
		hlp.SetActive (true);

	}
	public void help_hiad_things (GameObject hlp)
	{
		hlp.SetActive (false);
	
	}
	public void help_panil(GameObject p){
		p.SetActive (true);
		PlayerPrefs.SetInt ("t", times);
	}
	public void he(){
		PlayerPrefs.GetInt ("t");
	}
	public void help_change_wight(Rigidbody p){
		p.mass = 1;
	}
	public void Chinge_the_icon(GameObject i){
		i.SetActive (false);
	}
	public void Player_wight(Rigidbody player){
		player.mass = 1;
	}
	public void Wirning(GameObject wiring){
		wiring.SetActive (true);
	}
public void Wirning2(GameObject wiring2){
	wiring2.SetActive (true);
}
	public void Move(Rigidbody boll){
		boll.AddForce (90, 0, 0);
	}
	public void First_Time(){
		PlayerPrefs.SetInt ("ft", 1);
		Debug.Log (PlayerPrefs.GetInt ("ft"));
	
	} 
	public void Up(Rigidbody rd){
		rd.AddForce(0,0,FindObjectOfType<playermovement> ().k*Time.deltaTime);
	}
	public void Down(Rigidbody rd){
		rd.AddForce(0,0,FindObjectOfType<playermovement> ().k*Time.deltaTime);
	}
	public void Left(Rigidbody rd){
		rd.AddForce(FindObjectOfType<playermovement> ().x*Time.deltaTime,0,0);
	}
	public void Right(Rigidbody rd){
		rd.AddForce(-FindObjectOfType<playermovement> ().x*Time.deltaTime,0,0);
	}
	public void Restart(){
		PlayerPrefs.DeleteKey ("id");
		Debug.Log(PlayerPrefs.GetInt("id"));
		PlayerPrefs.DeleteKey ("ft");

	}
}
