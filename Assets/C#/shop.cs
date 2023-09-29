using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class shop : MonoBehaviour {
	public int cash;
	public int cash2;
	public Text uichash;

	 Button bought_thing;
	 Text price;
	public int price_to_int;
	// Use this for initialization
	void Start () {
		cash2 = cash;
	}
	
	// Update is called once per frame
	void Update () {
		uichash.text = "$ "+cash.ToString();
		bought_thing = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
		bought_thing.onClick.AddListener (onbuy);
		cash = cash2;
	}
	public void onbuy(){
		price = bought_thing.transform.Find ("price").GetComponent<Text>();
		price_to_int = int.Parse (price.text);
		if (cash >= price_to_int) {
			cash2 = cash - price_to_int;
		}
	}
}
