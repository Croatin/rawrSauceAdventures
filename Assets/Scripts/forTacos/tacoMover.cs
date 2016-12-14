using UnityEngine;
using System.Collections;

public class tacoMover : MonoBehaviour 
{

	public int speed;
	private int directionTracker;
	// Use this for initialization
	void Start () 
	{
		directionTracker = 1;
	}
	void Update () 
	{
		transform.Translate(Vector2.right * speed * Time.deltaTime * directionTracker);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "endOfGameR") {
			directionTracker = -1;
		}
		if (other.gameObject.tag == "knightDestroyer") {
			directionTracker = 1;
		}
	}

}
