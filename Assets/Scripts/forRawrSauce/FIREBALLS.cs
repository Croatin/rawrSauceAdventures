using UnityEngine;
using System.Collections;

public class FIREBALLS : MonoBehaviour 
{
	public GameObject rawrSauce;
	public GameObject fireBall; 
	//public int height;
	//private Vector3 rawrHeight = Vector3.up + height;
	// Use this for initialization
	void Start () 
	{
		rawrSauce = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Vector2 direction = this.
		//Input.GetMouseButtonDown(0)

		if(Input.GetKeyDown(KeyCode.F))
		{
			Instantiate(fireBall, transform.position, transform.rotation);
			rawrSauce.GetComponent<Animation>().Play("fireBreathe");
			GetComponent<AudioSource>().Play();
		}
	}
}
