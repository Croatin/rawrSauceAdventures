using UnityEngine;
using System.Collections;

public class pooSplosion : MonoBehaviour 
{

	public Vector2 explosionForce;
	public GameObject poop;
	public float radius;
	public int jump, back;
	private Collider2D expRadCollide;
	private Collider2D[] otherz;
	private GameObject expRad, particles;
	private GameObject withinExplosion;
	private float poopX, otherX;
	//private int looper;

	// Use this for initialization

	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	//playerX = player.transform.position.x;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "FireBall") 
		{
			poopX = poop.transform.position.x;
			//poop.rigidbody2D.AddForceAtPosition(explosionForce, transform.position);
			Destroy(poop);
			//Instantiate (particles, transform.position, transform.rotation);
			Collider2D[] otherz = Physics2D.OverlapCircleAll(transform.position, radius);
			//int looper = otherz.Length-1;
			for(int looper = otherz.Length-1; looper > 0; looper--)
			//while(looper >= 0)
			{
				otherX = otherz[looper].transform.position.x;
				withinExplosion = otherz[looper].GetComponent<Collider2D>().gameObject;
				if(poopX < otherX)
				{
					withinExplosion.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump);
					withinExplosion.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * back);
				}
				if(poopX > otherX)
				{
					withinExplosion.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump);
					withinExplosion.gameObject.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * back);
				}
				//looper--;
			}
		}
	}
}
