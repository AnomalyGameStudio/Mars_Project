using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour 
{
	public static GameController instance;

	public GameObject grassTilePrefab;
	public GameObject streetTilePrefab;

	public int mapSize;

	List<List<Tile>> map = new List<List<Tile>>();

	void Start () 
	{
		instance = this;
		GenerateMap();
	}
	
	void GenerateMap()
	{
		GameObject TileGroup = new GameObject();
		TileGroup.name = "TileGroup";
		
		map = new List<List<Tile>>();
		for (int i = 0; i < mapSize; i++) 
		{
			List<Tile> Row = new List<Tile>();
			for (int j = 0; j < mapSize; j++)
			{
				Tile tile = ((GameObject) Instantiate(grassTilePrefab, new Vector3(i - Mathf.Floor(mapSize/2), 0, -j + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				tile.gridPosition = new Vector2(i,j);
				tile.transform.parent = TileGroup.transform; //Adiciona o Tile ao GameObject groupTile
				Row.Add(tile);
			}
			map.Add(Row);
		}
	}
}
