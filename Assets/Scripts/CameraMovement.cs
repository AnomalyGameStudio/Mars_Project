using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour 
{	
	void Start () 
	{
	
	}

	void Update () 
	{
		//Keyboard scroll

		//TODO Movimento muito rapido, camera nao se move verticalmente (Fazer translaçao somente no Y)

		float translationX = Input.GetAxis("Horizontal");
		float translationY = Input.GetAxis("Vertical");
		float fastTranslationX = 2 * translationX;
		float fastTranslationY = 2 * translationY;

		if (Input.GetKey(KeyCode.LeftShift))
		{
			transform.Translate(fastTranslationX + fastTranslationY, 0, fastTranslationY - fastTranslationX);
		}
		else
		{
			transform.Translate(translationX + translationY, 0, translationY - translationX);
		}

		//Mouse Scroll

		//TODO This doesn't work
		/*
		float mousePosX = Input.mousePosition.x;
		float mousePosY = Input.mousePosition.y;
		float scrollDistance = 5;
		float scrollSpeed = 70;

		if (mousePosX < scrollDistance)
		{
			//Horizontal, left
			transform.Translate(-1, 0, 1);
		}

		if (mousePosX >= Screen.width - scrollDistance)
			//horizontal, right
		{
			transform.Translate(1, 0, -1);
		}
		
		//Vertical camera movement
		if (mousePosY < scrollDistance)
			//scrolling down
		{
			transform.Translate(-1, 0, -1);
		}
		if (mousePosY >= Screen.height - scrollDistance)
			//scrolling up
		{
			transform.Translate(1, 0, 1);
		}
		*/

		//Zoom
		//TODO It doesn't work also :S
		/*
		GameObject cameraTarget = GameObject.Find("Main Camera");

		if(Input.GetAxis("Mouse ScrollWheel") > 0 && cameraTarget.Camera.orthographicSize > 4)
		{
			cameraTarget.Camera.orthographicSize = cameraTarget.Camera.orthographicSize - 4;
		}

		if(Input.GetAxis("Mouse ScrollWheel") < 0 && cameraTarget.Camera.orthographicSize < 80)
		{
			cameraTarget.Camera.orthographicSize = cameraTarget.Camera.orthographicSize + 4;
		}

		if(Input.GetKeyDown("Mouse2"))
		{
			cameraTarget.Camera.orthographicSize = 5;
		}
		*/
	}
}
