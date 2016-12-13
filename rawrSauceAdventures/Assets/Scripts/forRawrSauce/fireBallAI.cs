using UnityEngine;
using System.Collections;

public class fireBallAI : MonoBehaviour 
{
	public float speed;
	public float maxDistance;
	public GameObject fireBall; 
	private GameObject player;
	private GameObject direction;
	private Vector2 fireProjection;

	private float playerX, directionX;

	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("mouth");
		direction = GameObject.FindGameObjectWithTag ("rawrFireDirection");

		playerX = player.transform.position.x;
		directionX = direction.transform.position.x;
		
		if (playerX < directionX) 
			fireProjection = Vector2.right;
		else 
		{
			fireProjection = -Vector2.right;
			Vector3 newScale = fireBall.transform.localScale;
			newScale.x *= -1;
			fireBall.transform.localScale = newScale;
		}
	}

	// Update is called once per frame
	void Update () 
	{


		transform.Translate(fireProjection * speed * Time.deltaTime);
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy") 
		{
			Destroy(fireBall);
		}
		if (other.gameObject.tag == "endOfGameR" || other.gameObject.tag == "endOfGameL") 
		{
			Destroy(fireBall);
		}
	}
}