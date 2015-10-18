using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StreetButton : MonoBehaviour 
{
	[SerializeField] private Button button = null;
	public GameObject streetTilePrefab;

	void start()
	{
		button.onClick.AddListener
		(
			() => 
			{
				//Codigo aqui!
				//addRoom();
				Debug.Log("BAM!"); 
			}
		);
	}


	void addStreet()
	{
		GameController gameController = GameController.instance;


	}
}
