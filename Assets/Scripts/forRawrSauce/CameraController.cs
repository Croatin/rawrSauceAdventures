using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public Vector3 offset;
	private GameObject playerFollower;
	// Use this for initialization
	void Start () 
	{
		playerFollower = GameObject.FindWithTag ("Player");
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.position = playerFollower.transform.position + offset;
	}
}

/*

public class CameraController : MonoBehaviour 
{
	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () 
	{
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;
	}
}

*/