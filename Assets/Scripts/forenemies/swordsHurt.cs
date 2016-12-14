using UnityEngine;
using System.Collections;

public class swordsHurt : MonoBehaviour 
{

	public int joomp = 10;
	public int back = 10;
	// Use this for initialization
	void Start () 
	{
	
	}

	void Update () 
	{
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Sword") 
		{
			GetComponent<Rigidbody2D>().AddForce((Vector2.up * joomp));
			GetComponent<Rigidbody2D>().AddForce((-Vector2.right * back));
		}
	}
}
/*
	rigidbody.AddForce((whateverObject.transform.position - transform.position) * someFactor * Time.smoothDeltaTime);
*/