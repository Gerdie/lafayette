using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControllerScript : MonoBehaviour {
	public const int gridRows = 3;
	public const int gridCols = 3;
	[SerializeField] private FarmTileBase farm_tile;

	// Use this for initialization
	void Start () {
		Vector3 startPos = farm_tile.transform.position;

		for (int y = 0; y < gridCols; y++) {
			for (int x = 0; x < gridRows; x++) {
				FarmTileBase tile;
				if (x == 0 && y == 0) {
					tile = farm_tile;
				} else {
					tile = Instantiate (farm_tile) as FarmTileBase;
				}
			}
		}
	}
    // Update is called once per frame
	void Update () {

	}
}
