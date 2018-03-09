using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEdge : MonoBehaviour {


	public Camera camera;
	public EdgeCollider2D edge;
	// Use this for initialization
	void Start () {/*
		Vector3 bottomLeft = camera.ScreenToWorldPoint (new Vector3 (0, 0, 0));
		Vector3 topLeft = camera.ScreenToWorldPoint (new Vector3 (0, Screen.height, 0));
		Vector3 topRight = camera.ScreenToWorldPoint (new Vector3 (Screen.width, Screen.height, 0));
		Vector3 bottomRight = camera.ScreenToWorldPoint (new Vector3 (Screen.width, 0, 0));
		edge.points = new Vector2[5] { bottomLeft, topLeft, topRight, bottomRight, bottomLeft };*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void CreateEdge()
	{
		Vector3 bottomLeft = camera.ScreenToWorldPoint (new Vector3 (0, 0, 0));
		Vector3 topLeft = camera.ScreenToWorldPoint (new Vector3 (0, Screen.height, 0));
		Vector3 topRight = camera.ScreenToWorldPoint (new Vector3 (Screen.width, Screen.height, 0));
		Vector3 bottomRight = camera.ScreenToWorldPoint (new Vector3 (Screen.width, 0, 0));
		edge.points = new Vector2[5] { bottomLeft, topLeft, topRight, bottomRight, bottomLeft };
	}
	

}

