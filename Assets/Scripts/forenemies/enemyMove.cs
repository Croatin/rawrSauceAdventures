using UnityEngine;
using System.Collections;

public class enemyMove : MonoBehaviour 
{
	public float moveSpeed = 10f;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
	}
}
