using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour 
{
	public GameObject cameraTarget;

	public float panSpeed;
	public float zoomSpeed;
	public float rotateSpeed;

	public float zoomMinLimit;
	public float zoomMaxLimit;

	private Vector2 panAxis = Vector2.zero;

	void Update () 
	{
		panControl();
		rotateControl();
		zoomControl();
	}

	//TODO Adicionar controle de camera pelo Mouse
	void panControl()
	{
		Vector3 movement = Vector3.zero;

		movement.x = Input.GetAxis("Horizontal");
		movement.y = Input.GetAxis("Vertical");

		transform.Translate(movement * Time.deltaTime * panSpeed, Space.Self);
	}

	//TODO Alterar os controles para possibilitar customizaçao
	void rotateControl()
	{
		if(Input.GetKey(KeyCode.E))
		{
			transform.RotateAround(cameraTarget.transform.position, Vector3.up, - rotateSpeed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.Q))
		{
			transform.RotateAround(cameraTarget.transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
		}
	}

	//TODO Estudar se essa e melhor soluçao
	void zoomControl()
	{
		float axis = GetZoomInputAxis();

		Camera camera = Camera.main;

		if(camera.orthographicSize > zoomMinLimit && axis < 0 || camera.orthographicSize < zoomMaxLimit && axis > 0)
		{
			Debug.Log("Size " + camera.orthographicSize + " axis: " + axis);
			camera.orthographicSize += axis * Time.deltaTime * zoomSpeed;
		}
	}

	//TODO adicionar Zoom atraves do teclado com possibilidade de customizaçao
	public float GetZoomInputAxis()
	{
		float value = 0;

		/*
		if (Input.GetKey(zoomOut))
		{
			value = -0.3f;
		}
		else if (Input.GetKey(zoomIn))
		{
			value = 0.3f;
		}
		*/
		if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			value = -1;
		}
		else if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			value = 1;
		}

		return value;
	}
}
