using UnityEngine;
using System.Collections;

public class inHandFollower : MonoBehaviour {

	private GameObject player;
	private Vector3 offset;
	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("arm");
		offset = (Vector3.back / 9) + (Vector3.down / -9);
	}
	
	// Update is called once per frame
	void Update () 
	{
		//player = GameObject.FindGameObjectWithTag ("Player");
		transform.position = player.transform.position - offset;
	}
}
