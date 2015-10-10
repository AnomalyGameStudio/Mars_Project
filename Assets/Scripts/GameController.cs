using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour 
{
	public GameObject grassTile;
	public GameObject street;

	public int mapSize;

	List<List<SquareTile>> map = new List<List<SquareTile>>();

	void Start () 
	{
		GenerateMap();
	}
	
	void GenerateMap()
	{
		GameObject TileGroup = new GameObject();
		TileGroup.name = "TileGroup";
		
		map = new List<List<SquareTile>>();
		for (int i = 0; i < mapSize; i++) 
		{
			List<SquareTile> Row = new List<SquareTile>();
			for (int j = 0; j < mapSize; j++)
			{
				SquareTile tile = ((GameObject) Instantiate(grassTile, new Vector3(i - Mathf.Floor(mapSize/2), 0, -j + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<SquareTile>();
				tile.gridPosition = new Vector2(i,j);
				tile.transform.parent = TileGroup.transform; //Adiciona o Tile ao GameObject groupTile
				Row.Add(tile);
			}
			map.Add(Row);
		}
	}
}
