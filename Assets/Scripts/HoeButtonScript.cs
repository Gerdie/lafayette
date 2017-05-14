using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoeButtonScript : MonoBehaviour {

	public GameObject Hand = GameObject.FindGameObjectWithTag("Player");

	[SerializeField] private Sprite button_up;
	[SerializeField] private Sprite button_down;

	public void OnMouseDown(){
		int inHand = Hand.GetComponent<HandScript> ().ToolInHand;
		if (inHand == 0) { // 0 means nothing
			GetComponent<SpriteRenderer>().sprite = button_down;
			inHand = 1; // 1 means hoe
		} else if (inHand == 1) {
			GetComponent<SpriteRenderer>().sprite = button_up;
			inHand = 0;
		}
//		handScript.ToolInHand = "hoe";
//		Debug.Log ("you are " + handScript.ToolInHand);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
