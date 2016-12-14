using UnityEngine;
using System.Collections;

public class pickUpPoop : MonoBehaviour 
{

	public GameObject poopInHand, poop;
	private GameObject arm;
	public bool holdingPoop = false;

	// Use this for initialization
	void Start () 
	{
		arm = GameObject.FindGameObjectWithTag ("arm");
	}
	
	// Update is called once per frame
	void Update () 
	{
		//poopInHand = GameObject.FindGameObjectWithTag ("poopInHand");
		poop = GameObject.FindGameObjectWithTag ("poop");
	}
	void OnTriggerEnter2D(Collider2D other)
	{
//		Debug.Log ("I occure");
		if(other.gameObject.tag  == ("Player") && !holdingPoop)
		{
//			Debug.Log ("finding the poop");
			Destroy(poop);
			Instantiate(poopInHand, arm.transform.position, arm.transform.rotation);
			holdingPoop = true;
//			Debug.Log ("Why am I not being destroyed?");
		}
	}
}
