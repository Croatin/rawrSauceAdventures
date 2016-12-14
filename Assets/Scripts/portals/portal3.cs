using UnityEngine;
using System.Collections;

public class portal3 : MonoBehaviour {

	private GameObject player;
	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject == player)
		{
			Debug.Log ("i'm colliding");
			Destroy (player);
			
			Application.LoadLevel("level4");
		}
	}
}
