using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControllerScript : MonoBehaviour {
	public GameObject[] farmTiles;
	private int gridCols = 4;
	private int gridRows = 4;
	private List <Vector3> gridPositions = new List<Vector3>();
	[SerializeField] private FarmTileBase farm_tile;

	// Set wonky positions for strangely-shaped tiles
	void SetScene () {
		gridPositions.Add(new Vector3 (0f, 0f, 0f));
		gridPositions.Add(new Vector3 (0.887, 0.747, 0f));
		gridPositions.Add(new Vector3 (1.78, 1.49, 0f));
		gridPositions.Add(new Vector3 (0.89, -0.736, 0f));
		gridPositions.Add(new Vector3 (2.66, 0.747, 0f));
		gridPositions.Add(new Vector3 (1.79, -1.47, 0f));
		gridPositions.Add(new Vector3 (2.68, -0.72, 0f));
		gridPositions.Add(new Vector3 (3.56, 0.02, 0f));
	}

	// Use this for initialization
	void Start () {

		for (int y = 0; y < gridCols; y++) {
			for (int x = 0; x < gridRows; x++) {
				FarmTileBase tile;
				tile = Instantiate (farm_tile, gridPositions[y+x], Quaternion.identity) as FarmTileBase;
			}
		}
	}
    // Update is called once per frame
	void Update () {

	}
}
