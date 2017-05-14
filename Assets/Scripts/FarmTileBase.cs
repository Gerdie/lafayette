using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmTileBase : MonoBehaviour {
	[SerializeField] private Sprite farm_tile;
	[SerializeField] private Sprite soil_tile;

//	public GameObject Hand;
	public GameObject Hand = GameObject.FindGameObjectWithTag("Player");

	public void OnMouseDown() {
		int inHand = Hand.GetComponent<HandScript>().ToolInHand;
		if (inHand == 1) { // 0 means nothing
			GetComponent<SpriteRenderer> ().sprite = soil_tile;
		} 
	}

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().sprite = farm_tile;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
