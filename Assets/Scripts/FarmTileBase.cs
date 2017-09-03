using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Plant;

public class FarmTileBase : MonoBehaviour {
	[SerializeField] private Sprite farm_tile;
	[SerializeField] private Sprite soil_tile;
	private bool is_hoed;
	private bool is_planted;
	private Plant plant;
	private int days_growing;

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().sprite = farm_tile;
		is_hoed = false;
		is_planted = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Hoe() {
		is_hoed = true;
		GetComponent<SpriteRenderer> ().sprite = soil_tile;
	}

	public void Plant(object Plant) {
		if (is_hoed && !is_planted) {
			is_planted = true;
			plant = Plant;
			days_growing = 0;
		}
	}


}
